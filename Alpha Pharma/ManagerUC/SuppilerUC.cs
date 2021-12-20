using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC
{
    public partial class SuppilerUC : UserControl
    {
        Supplier supplier = new Supplier();
        public SuppilerUC()
        {
            InitializeComponent();
            dgv_Supplier_info.DataSource = Supplier.GetSuppliers();
        }
        
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txb_SN.Text.Trim() != "" && txb_SA.Text.Trim() != "" && txb_SPN.Text.All(char.IsDigit))
            {

                try
                {
                    supplier.Sup_name = txb_SN.Text;
                    supplier.Sup_address = txb_SA.Text;
                    supplier.Sup_phone = txb_SPN.Text;
                    supplier.Suppplier_Desc = txb_sup_desc.Text;

                    bool success = supplier.InsertSupplier(supplier);

                    dgv_Supplier_info.DataSource = Supplier.GetSuppliers();
                    if (success)
                    {
                        MessageBox.Show(@"Supplier has been added successfully");
                        ClearControls();
                    }
                    else
                        MessageBox.Show(@"Error occured. Please try again...");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Empty text please Fill all field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txb_SN.Text.Trim() != "" && txb_SA.Text.Trim() != "" && txb_SPN.Text.All(char.IsDigit))
            {
                try
                {
                    supplier.Sup_id = lb_id.Text;
                    supplier.Sup_name = txb_SN.Text;
                    supplier.Sup_address = txb_SA.Text;
                    supplier.Sup_phone = txb_SPN.Text;
                    supplier.Suppplier_Desc = txb_sup_desc.Text;

                    var success = supplier.UpdateSupplier(supplier);

                    dgv_Supplier_info.DataSource = Supplier.GetSuppliers();
                    if (success)
                    {
                        MessageBox.Show(@"Supplier has been Updated successfully");
                        ClearControls();
                    }
                    else
                        MessageBox.Show(@"Error occured,Please try again..");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty text please Fill all field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                supplier.Sup_id = lb_id.Text;
                supplier.Sup_name = txb_SN.Text;
                var Success = supplier.DeleteSupplier(supplier);
                dgv_Supplier_info.DataSource = Supplier.GetSuppliers();
                if (Success)
                {
                    MessageBox.Show(@"Supplier has been Deleted successfully ");
                    ClearControls();
                }
                else
                    MessageBox.Show(@"Error occured. Please try again...");
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        void ClearControls()
        {
            lb_id.Text = "";
            txb_SA.Clear();
            txb_SN.Clear();
            txb_SPN.Clear();
        }

        private void dgv_Supplier_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_id.Text = dgv_Supplier_info.Rows[index].Cells[0].Value.ToString();
                txb_SN.Text = dgv_Supplier_info.Rows[index].Cells[1].Value.ToString();
                txb_SA.Text = dgv_Supplier_info.Rows[index].Cells[2].Value.ToString();
                txb_SPN.Text = dgv_Supplier_info.Rows[index].Cells[3].Value.ToString();
                txb_sup_desc.Text = dgv_Supplier_info.Rows[index].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txb_SPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if (txb_SPN.Text.Count(Char.IsDigit) == 9)
                    e.Handled = true;
            }
        }

        private void SuppilerUC_Load(object sender, EventArgs e)
        {
            if (User.User_Type == "Employee")
            {
                btn_Delete.Enabled = false;
                btn_Update.Enabled = false;
            }
        }

        
        private void txb_SN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txb_SN.Text, "^[A-Za-z]{1,50}$"))
            {
                txb_SN.Focus();
                errorProvider1.SetError(txb_SN, "Please Enter The Supplier Name without any numbers or 1@_=&*^%$#");
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void txb_SA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txb_SA.Text, "^[A-Za-z]{1,50}$"))
            {
                txb_SA.Focus();
                errorProvider1.SetError(txb_SA, "Please Enter The Supplier Address without any numbers or 1@_=&*^%$#");
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void dgv_Supplier_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String info;
            if (e.ColumnIndex == 4)
            {
                info = dgv_Supplier_info.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                MessageBox.Show(info, "All Description", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txb_search_TextChanged_1(object sender, EventArgs e)
        {
            DataView Dv = new DataView(Supplier.GetSuppliers());
            Dv.RowFilter = "Name like '%" + txb_search.Text + "%'";
            dgv_Supplier_info.DataSource = Dv;
        }

        private void txb_SPN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txb_SPN.Text.Count(Char.IsDigit) != 9)
            {
                errorProvider1.SetError(txb_SPN, "The phone number should have 9 number only!");
                txb_SPN.Focus();
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }
    }
}
