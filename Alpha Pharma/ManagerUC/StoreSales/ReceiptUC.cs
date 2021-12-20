using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.StoreSales
{
    public partial class ReceiptUC : UserControl
    {
        private Receipt receipt = new Receipt();
        private ReceiptDetails receiptDetails = new ReceiptDetails();
        public int lastReceiptID;
        public ReceiptUC()
        {
            InitializeComponent();
        }



        private void ReceiptUC_Load(object sender, EventArgs e)
        {
            combo_product.DataSource = Store.GetStore();
            combo_product.DisplayMember = "DrugInfo";
            combo_product.ValueMember = "StoreID";
            combo_product.SelectedIndex = -1;

            combo_customerName.DataSource = Customer.GetCustomers();
            combo_customerName.DisplayMember = "FullName";
            combo_customerName.ValueMember = "ID";
            combo_customerName.SelectedIndex = -1;

            txb_empUsername.Text = User.User_Name;
            txb_available.Text = "0";
            txb_price.Clear();

            combo_product.Focus();

            btn_add_lst.Enabled = false;
            btn_print.Enabled = false;
        }

        private void combo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Dv = new DataView(Store.GetStore());
            Dv.RowFilter = "Convert(StoreID,'System.String') like '%" + combo_product.SelectedValue + "%'";
            foreach (DataRowView drv in Dv)     
            {
                txb_available.Text = drv["Product_Quantity"].ToString();
                txb_price.Text = drv["Product_Price"].ToString();
            }

            txb_qty.Focus();
            txb_qty.Clear();
        }

        private void txb_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_qty.Text.Length>0 && txb_qty.Text.All(char.IsDigit))
                {
                    if (Convert.ToInt32(txb_qty.Text) <= Convert.ToInt32(txb_available.Text) && combo_product.Text.Length>0)
                    {
                        btn_add_lst.Enabled = true;
                        txb_totalPrice.Text = (Convert.ToInt32(txb_price.Text) * Convert.ToInt32(txb_qty.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Quantity more than Available !","Focus Please",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        txb_qty.Clear();
                        txb_totalPrice.Clear();
                    }
                }
                else if (!txb_qty.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please, Enter Only Numbers!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_qty.Clear();
                    txb_totalPrice.Clear();
                }
                else
                {
                    btn_add_lst.Enabled = false;
                }
            }
            catch (Exception)
            {
                txb_qty.Clear();
            }
        }

        private void btn_add_lst_Click(object sender, EventArgs e)
        {
            if (lstv.Items.Count > 0)
            {
                bool found = false;

                foreach (ListViewItem item in lstv.Items)
                {
                    if (item.SubItems[0].Text == combo_product.SelectedValue.ToString())
                    {
                        found = true;
                        MessageBox.Show("Product Alraedy Added!", "Really!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearControls();
                        break;
                    }
                }

                if (!found)
                {
                     InsertIntoLisetView();
                }
            }
            else
            {
                InsertIntoLisetView();
            }
        }

        void InsertIntoLisetView()
        {
            string[] arr = new string[5];
            arr[0] = combo_product.SelectedValue.ToString();
            arr[1] = combo_product.Text;
            arr[2] = txb_price.Text;
            arr[3] = txb_qty.Text;
            arr[4] = txb_totalPrice.Text;

            ListViewItem list = new ListViewItem(arr);
            lstv.Items.Add(list);

            txb_grandTotal.Text = (Convert.ToInt32(txb_totalPrice.Text) + Convert.ToInt32(txb_grandTotal.Text)).ToString();
            txb_subTotal.Text = txb_grandTotal.Text;
            txb_TotalQty.Text = (Convert.ToInt32(txb_qty.Text) + Convert.ToInt32(txb_TotalQty.Text)).ToString();

            ClearControls();
        }

        private void combo_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_discount.Text.Length>0)
            {
                float dis = (Convert.ToInt32(txb_grandTotal.Text) * (Convert.ToSingle(combo_discount.Text) / 100));
                txb_subTotal.Text = (Convert.ToInt32(txb_grandTotal.Text) - dis).ToString();
            }
        }

        private void txb_paid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_paid.Text.Length > 0  &&  (Convert.ToInt32(txb_paid.Text) >= Convert.ToInt32(txb_subTotal.Text)))
                {

                    txb_remain.Text = (Convert.ToInt32(txb_paid.Text) - Convert.ToInt32(txb_subTotal.Text)).ToString();
                    btn_print.Enabled = true;
                }
                else 
                {
                    // MessageBox.Show("The Paid Amount Is less than the Total!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_print.Enabled = false;
                }
            }
            catch (Exception)
            {   
                txb_paid.Clear();
                txb_remain.Clear();
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            combo_discount.Enabled = false;

            receipt.Emp_ID = User.User_ID.ToString();
            receipt.Total = float.Parse(txb_subTotal.Text);
            receipt.QTY = txb_TotalQty.Text;

            if (combo_customerName.Text.Length>0)
            {
                receipt.Cus_ID = (int)combo_customerName.SelectedValue;
            }
            else
            {
                receipt.Cus_ID = 0;
            }

            lastReceiptID = receipt.InsertReceipt(receipt);
            dgv_receipt_info.DataSource = Receipt.GetReceipt();

            //Reduce the Quantity form Store Table
            foreach (ListViewItem item in lstv.Items)
            {
                receiptDetails.Pro_ID = item.SubItems[0].Text;
                receiptDetails.Pro_Qty = item.SubItems[3].Text;
                receiptDetails.UpdateProQty(receiptDetails);
            }

            btn_confirm.Enabled = false;

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            //Inserting Into ReceiptDetail Table
            int rows = 0;
            foreach (ListViewItem item in lstv.Items)
            {
                receiptDetails.Rec_ID = lastReceiptID.ToString();
                receiptDetails.Pro_ID = item.SubItems[0].Text;
                receiptDetails.Pro_Price = item.SubItems[2].Text;
                receiptDetails.Pro_Qty = item.SubItems[3].Text;
                rows = receiptDetails.InsertReceiptDetail(receiptDetails);
                rows++;
            }

            if (rows>0)
            {
                MessageBox.Show(rows+ " " + "Receipt has been added successfully");

                //Printing

                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show(@"Error occurd. Pleas try again...");

            }

            lstv.Items.Clear();
            dgv_receipt_info.DataSource = ReceiptDetails.GetReceiptDetail();
        }

        void ClearControls()
        {
            txb_available.Clear();
            txb_price.Clear();
            combo_product.Text = "";
            txb_qty.Clear();
            txb_totalPrice.Clear();
        }

        private void btn_delect_lst_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstv.SelectedItems.Count;)  
            {
                if (lstv.SelectedItems[i].Selected)
                {
                    txb_grandTotal.Text = (Convert.ToInt32(txb_grandTotal.Text) - Convert.ToInt32(lstv.SelectedItems[i].SubItems[4].Text)).ToString();
                    txb_subTotal.Text = txb_grandTotal.Text;
                    txb_TotalQty.Text = (Convert.ToInt32(txb_TotalQty.Text) - Convert.ToInt32(lstv.SelectedItems[i].SubItems[3].Text)).ToString();
                    lstv.SelectedItems[i].Remove();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 150;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Alpha Pharma",new Font("Courier New",20),new SolidBrush(Color.Black),startx + 180,starty);

            string ID = "Receipt ID:" + lastReceiptID;
            graphics.DrawString(ID, font, new SolidBrush(Color.Black), startx, starty + offset + 5);

            string top = "Date:" + DateTime.Now.ToString().PadRight(5);
            graphics.DrawString(top,font, new SolidBrush(Color.Black), startx, starty + offset + 30);
            offset = offset + 60;

            string emp = "Employee:" + User.User_Name;
            graphics.DrawString(emp, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            string cus = "Customer:" + combo_customerName.Text;
            graphics.DrawString(cus, font, new SolidBrush(Color.Black), startx, starty + offset);

            offset = offset + (int)FontHeight;
            graphics.DrawString("------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Drug\t\t\t  Price   QTY\t Total",font,new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            for (int i = 0; i < lstv.Items.Count; i++)
            {
                graphics.DrawString(lstv.Items[i].SubItems[1].Text +"\t\t"+ lstv.Items[i].SubItems[2].Text + "\t   " + lstv.Items[i].SubItems[3].Text + "\t\t  " + lstv.Items[i].SubItems[4].Text+"\t",
                    new Font("Courier New",12), new SolidBrush(Color.Black) , startx, starty + offset);
                offset = offset + 20;
            }
            offset = offset + (int)FontHeight+5;
            graphics.DrawString("------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;

            graphics.DrawString("TOTAL       : " + txb_grandTotal.Text + ".00",font,new SolidBrush(Color.Black), startx, starty + offset );
            offset = offset + 20;

            graphics.DrawString("DISCOUNT    : " + combo_discount.Text + "%",font,new SolidBrush(Color.Black), startx, starty + offset );
            offset = offset + 20;

            graphics.DrawString("SUB TOTAL   : " + txb_subTotal.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("PAID AMOUNT : " + txb_paid.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("REFUND      : " + txb_remain.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("Thank You ^-^", new Font("Courier New", 20), new SolidBrush(Color.Black), startx + 180, starty + offset);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            txb_available.Clear();
            txb_price.Clear();
            combo_product.Text = "";
            txb_qty.Clear();
            txb_totalPrice.Clear();
            lstv.Items.Clear();
            txb_TotalQty.Clear();
            txb_qty.Clear();
            combo_discount.Text = "0";
            txb_grandTotal.Clear();
            txb_subTotal.Clear();
            txb_paid.Clear();
            txb_remain.Clear();
        }
    }
}
