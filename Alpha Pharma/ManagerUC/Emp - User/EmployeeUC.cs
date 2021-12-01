using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Pharma.ManagerUC
{
    public partial class EmployeeUC : UserControl
    {
        private Employee employee = new Employee();
        public EmployeeUC()
        {
            InitializeComponent();
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
                    MessageBox.Show(Success ? @"Employee info has been added" : @"Error occurred. Please try again");
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
                MessageBox.Show(success ? @"Employee info has been updated." : @"Error occurred. Please try again");
            }

            catch (Exception)
            {
                MessageBox.Show("Please try again", "Error exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Emp_clear_Click(object sender, EventArgs e)
        {
            txb_Emp_FN.Clear();
            txb_Emp_LN.Clear();
            txb_Emp_salary.Clear();
            txb_Emp_phone_no.Clear();
            txb_Emp_email.Clear();
            compo_Emp_gender.SelectedIndex = -1;
            compo_Emp_position.SelectedIndex = -1;
            compo_Emp_DOB.Text = DateTime.Now.ToString();
        }

        private void btn_Emp_delete_Click(object sender, EventArgs e)
        {
            employee.Id = lb_Emp_id.Text;
            employee.FName = txb_Emp_FN.Text;
            var success = employee.DeleteEmployee(employee);
            dgv_Employee_info.DataSource = Employee.GetEmployees();
            MessageBox.Show(success ? @"Employee has been Deleted. " : @"Error occurred. please try again");
        }

        private void dgv_Employee_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                compo_Emp_DOB.Text = dgv_Employee_info.Rows[index].Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
