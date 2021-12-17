using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Alpha_Pharma.ManagerUC
{
    public partial class EmployeeUC : UserControl
    {
        private static string employeeConn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        private Employee employee = new Employee();
        public EmployeeUC()
        {
            InitializeComponent();
            errorProvider1.Clear();
            dgv_Employee_info.DataSource = Employee.GetEmployees();
        }

        private void btn_Emp_Click_Click(object sender, EventArgs e)
        {
            if (txb_Emp_FN.Text.Trim() != "" && txb_Emp_LN.Text.Trim() != ""
            && txb_Emp_salary.Text.Trim() != "" && txb_Emp_phone_no.Text.All(char.IsDigit) 
            && txb_Emp_email.Text.Trim() != "" && compo_Emp_gender.Text.Trim() != ""
            && compo_Emp_position.Text.Trim() != "")
            {
                try
                {
                    employee.Id = lb_Emp_id.Text;
                    employee.FName = txb_Emp_FN.Text;
                    employee.LName = txb_Emp_LN.Text;
                    employee.Salary = txb_Emp_salary.Text;
                    employee.Phone = txb_Emp_phone_no.Text;
                    employee.Email = txb_Emp_email.Text;
                    employee.Gender = compo_Emp_gender.Text;
                    employee.Position = compo_Emp_position.Text;
                    employee.Dob = compo_Emp_DOB.Text;

                    bool Success = employee.InsertEmployee(employee);
                    dgv_Employee_info.DataSource = Employee.GetEmployees();
                    if (Success)
                    {
                        MessageBox.Show("Employee info has been added");
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred. Please try again");
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Error", "Error exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty text please Fill all field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                employee.Id = lb_Emp_id.Text;
                employee.FName = txb_Emp_FN.Text;
                employee.LName = txb_Emp_LN.Text;
                employee.Salary = txb_Emp_salary.Text;
                employee.Phone = txb_Emp_phone_no.Text;
                employee.Email = txb_Emp_email.Text;
                employee.Gender = compo_Emp_gender.Text;
                employee.Position = compo_Emp_position.Text;
                employee.Dob = compo_Emp_DOB.Text;

                var success = employee.UpdateEmployee(employee);
                dgv_Employee_info.DataSource = Employee.GetEmployees();
                if (success)
                {
                    MessageBox.Show("Employee info has been updated");
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Error occurred. Please try again");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please try again", "Error exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Emp_clear_Click(object sender, EventArgs e)
        {
            ClearControls();
            compo_Emp_DOB.Format = DateTimePickerFormat.Custom;
            
        }

        private void btn_Emp_delete_Click(object sender, EventArgs e)
        {
            employee.Id = lb_Emp_id.Text;
            employee.FName = txb_Emp_FN.Text;
            var success = employee.DeleteEmployee(employee);
            dgv_Employee_info.DataSource = Employee.GetEmployees();
            if (success)
            {
                MessageBox.Show("Employee info has been deleted");
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error occurred. Please try again");
            }
        }

        void ClearControls()
        {
            lb_Emp_id.Text = "";
            txb_Emp_FN.Clear();
            txb_Emp_LN.Clear();
            txb_Emp_salary.Clear();
            txb_Emp_phone_no.Clear();
            txb_Emp_email.Clear();
            compo_Emp_gender.SelectedIndex = -1;
            compo_Emp_position.SelectedIndex = -1;
            compo_Emp_DOB.CustomFormat = " ";
        }

        private void txb_Emp_phone_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if (txb_Emp_phone_no.Text.Count(Char.IsDigit) == 9)
                    e.Handled = true;
            }
        }

        private void dgv_Employee_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_Emp_id.Text = dgv_Employee_info.Rows[index].Cells[0].Value.ToString();
                txb_Emp_FN.Text = dgv_Employee_info.Rows[index].Cells[1].Value.ToString();
                txb_Emp_LN.Text = dgv_Employee_info.Rows[index].Cells[2].Value.ToString();
                txb_Emp_salary.Text = dgv_Employee_info.Rows[index].Cells[3].Value.ToString();
                txb_Emp_phone_no.Text = dgv_Employee_info.Rows[index].Cells[4].Value.ToString();
                txb_Emp_email.Text = dgv_Employee_info.Rows[index].Cells[5].Value.ToString();
                compo_Emp_gender.Text = dgv_Employee_info.Rows[index].Cells[6].Value.ToString();
                compo_Emp_position.Text = dgv_Employee_info.Rows[index].Cells[7].Value.ToString();
                compo_Emp_DOB.Format = DateTimePickerFormat.Short;

            }
            catch (Exception)
            {
                return;
            }
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            double i = 0;
            if (double.TryParse(txb_Emp_salary.Text, out i))
            {
                errorProvider1.SetError(txb_Emp_salary, "");
                e.Cancel = false;
            }
           
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txb_Emp_salary, "Its allowad number only");
            }
        }

        private void Control_Validating2(object sender, CancelEventArgs e)
        {
            //double i = 0;
            //if (double.TryParse(txb_Emp_phone_no.Text, out i))
            //{
            //    errorProvider1.SetError(txb_Emp_salary, "");
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txb_Emp_salary, "Its allowad number only");
            //}

            //if you want it to work delete the txb_Emp_phone_no_KeyPress or see anything else!....

        }

        private void Contr_val(object sender, CancelEventArgs e)
        {
            

        }

        private void txb_Email_Validating(object sender, CancelEventArgs e)
        {
            Contr_val(sender, e);
            string error = null;
            try
            {
                new MailAddress(txb_Emp_email.Text);
            }
            catch (Exception)
            {
                error = "Please use a valid format email";
                e.Cancel = true;

            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void compo_Emp_DOB_MouseDown(object sender, MouseEventArgs e)
        {
            compo_Emp_DOB.CustomFormat = "dd/MM/yy";
        }
    
        DataTable dataTable = new DataTable();
        private void EmployeeUC_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(employeeConn))
            {
                con.Open();
                using (SqlCommand comm = new SqlCommand("Select * from Employees ", con))
               
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comm))
                    {
                        adapter.Fill(dataTable);
                        dgv_Employee_info.DataSource = dataTable;
                    }
                }
            }

        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = new DataView(dataTable);
            Dv.RowFilter = "emp_fname like '%" + txb_search.Text + "%'";
            dgv_Employee_info.DataSource = Dv;
        }

        private void Contr_val_Firstname(object sender, CancelEventArgs e)
        {
          
        }

        private void txb_Emp_FN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Emp_FN_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((Control)sender).Text))
            {

                ((Control)sender).Focus();
                errorProvider1.SetError((Control)sender, "This field is required!");
            }
            else
            {

                errorProvider1.SetError((Control)sender, null);
            }
        }
    }
}
