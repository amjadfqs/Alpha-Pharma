using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.StoreSales
{
    public partial class ReceiptUC : UserControl
    {
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
            if (txb_qty.Text.Length>0)
            {
                if (Convert.ToInt32(txb_qty.Text) <= Convert.ToInt32(txb_available.Text) && combo_product.Text.Length>0)
                {
                    txb_totalPrice.Text = (Convert.ToInt32(txb_price.Text) * Convert.ToInt32(txb_qty.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Quantity more than Available !");
                    txb_qty.Clear();
                    txb_totalPrice.Clear();
                }
            }

        }

        private void btn_add_lst_Click(object sender, EventArgs e)
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
            if (txb_paid.Text.Length>0)
            {
                txb_remain.Text = (Convert.ToInt32(txb_paid.Text) - Convert.ToInt32(txb_subTotal.Text)).ToString();
            }
        }
    }
}
