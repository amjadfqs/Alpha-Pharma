using System;
using System.Linq;
using System.Windows.Forms;

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
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txb_SPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
