using System;
using System.Linq;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC
{
    public partial class CustomerUC : UserControl
    {
        Customer custmer = new Customer();
        public CustomerUC()
        {
            InitializeComponent();
            dgv_customer_info.DataSource = Customer.GetCustomers();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txb_CFN.Text.Trim() != "" && txb_CLN.Text.Trim() != "" && mb_CPN.Text.All(char.IsDigit) &&
                combo_CG.Text.Trim() != "" )
            {
                try
                {
                    custmer.CuFirstName = txb_CFN.Text;
                    custmer.CuLastName = txb_CLN.Text;
                    custmer.CuNumber = mb_CPN.Text;
                    custmer.Gender = combo_CG.Text;
                    custmer.Date = datetimepicker_CD.Text;
                    custmer.Customer_Desc = txb_cus_desc.Text;

                    bool success = custmer.InsertCustomer(custmer);

                    dgv_customer_info.DataSource = Customer.GetCustomers();
                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(@"User Added");
                    }
                    else
                        MessageBox.Show(@"Error Happened");
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txb_CFN.Text.Trim() != "" && txb_CLN.Text.Trim() != "" && mb_CPN.Text.All(char.IsDigit) &&
                combo_CG.Text.Trim() != "")
            {
                try
                {
                    custmer.ID = id_lb.Text;
                    custmer.CuFirstName = txb_CFN.Text;
                    custmer.CuLastName = txb_CLN.Text;
                    custmer.CuNumber = mb_CPN.Text;
                    custmer.Gender = combo_CG.Text;
                    custmer.Date = datetimepicker_CD.Text;
                    custmer.Customer_Desc = txb_cus_desc.Text;

                    bool success = custmer.UpdateCustomer(custmer);

                    dgv_customer_info.DataSource = Customer.GetCustomers();
                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(@"User Updated");
                    }
                    else
                        MessageBox.Show(@"Error Happened");
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            id_lb.Text = "";
            txb_CFN.Text = "";
            txb_CLN.Text = "";
            mb_CPN.Text = "";
            combo_CG.SelectedIndex = -1;
            txb_cus_desc.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                custmer.ID = id_lb.Text;
                bool success = custmer.DeleteCustomer(custmer);

                dgv_customer_info.DataSource = Customer.GetCustomers();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show(@"User Deleted");
                }
                else
                    MessageBox.Show(@"Error Happened");
            }
            catch (Exception exce)
            {
                MessageBox.Show("Error" + exce.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_customer_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                id_lb.Text = dgv_customer_info.Rows[index].Cells[0].Value.ToString();
                txb_CFN.Text = dgv_customer_info.Rows[index].Cells[1].Value.ToString();
                txb_CLN.Text = dgv_customer_info.Rows[index].Cells[2].Value.ToString();
                mb_CPN.Text = dgv_customer_info.Rows[index].Cells[3].Value.ToString();
                combo_CG.Text = dgv_customer_info.Rows[index].Cells[4].Value.ToString();
                datetimepicker_CD.Text = dgv_customer_info.Rows[index].Cells[5].Value.ToString();
                txb_cus_desc.Text = dgv_customer_info.Rows[index].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void mb_CPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if (mb_CPN.Text.Count(Char.IsDigit) == 9)
                    e.Handled = true;
            }
        }

        private void CustomerUC_Load(object sender, EventArgs e)
        {
            if (User.User_Type == "Employee")
            {
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }
    }
}
