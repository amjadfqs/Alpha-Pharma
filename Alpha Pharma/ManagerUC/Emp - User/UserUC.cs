using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alpha_Pharma.Classes;
using Alpha_Pharma.Properties;

namespace Alpha_Pharma.ManagerUC
{
    public partial class UserUC : UserControl
    {
        private User user = new User();

        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        public UserUC()
        {
            InitializeComponent();
            dgv_user_info.DataSource = User.GetUser();
        }

        private void UserUC_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Select emp_phone from Employees", con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        while (DR.Read())
                        {
                            //type = DR["user_type"].ToString();
                            mycollection.Add(DR.GetValue(0).ToString());
                        }
                    }
                }
                txb_Sphone.AutoCompleteCustomSource = mycollection;
            }
        }

        private void txb_Sphone_TextChanged(object sender, EventArgs e)
        {
            if (txb_Sphone.Text.All(char.IsDigit))
            {
                using (SqlConnection con = new SqlConnection(myconn))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("Select emp_id, emp_fname, emp_lname, emp_position from Employees where emp_phone = @Phone", con))
                    {
                        com.Parameters.AddWithValue("@Phone", txb_Sphone.Text);

                        using (SqlDataReader DR = com.ExecuteReader())
                        {
                            try
                            {
                                while (DR.Read())
                                {
                                    txb_ID.Text = DR.GetValue(0).ToString();
                                    txb_Fname.Text = DR.GetValue(1).ToString();
                                    txb_Lname.Text = DR.GetValue(2).ToString();
                                    txb_posi.Text = DR.GetValue(3).ToString();
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Please Choose a number");
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter only numbers!");
                txb_Sphone.Text = "";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_username.Text) && !string.IsNullOrEmpty(txb_pass.Text))
            {
                try
                {
                    user.ID = txb_ID.Text;
                    user.UserName = txb_username.Text;
                    user.Password = txb_pass.Text;
                    user.Type = txb_posi.Text;

                    bool success = user.InsertUser(user);
                    dgv_user_info.DataSource = User.GetUser();
                    if (success)
                    {
                        txb_ID.Text = "";
                        txb_Fname.Text = "";
                        txb_Lname.Text = "";
                        txb_pass.Text = "";
                        txb_username.Text = "";
                        txb_Sphone.Text = "";
                        txb_posi.Text = "";

                        MessageBox.Show(@"User has been added successfully");
                    }
                    else
                    {
                        MessageBox.Show(@"Error occurd. Pleas try again...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You cannot add two users with same ID!" , " Trying to Duplicate!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter User name & Password!", "Error");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_username.Text) && !string.IsNullOrEmpty(txb_pass.Text))
            {
                try
                {
                    user.ID = txb_ID.Text;
                    user.UserName = txb_username.Text;
                    user.Password = txb_pass.Text;
                    user.Type = txb_posi.Text;

                    bool success = user.UpdateUser(user);
                    dgv_user_info.DataSource = User.GetUser();
                    if (success)
                    {
                        txb_ID.Text = "";
                        txb_Fname.Text = "";
                        txb_Lname.Text = "";
                        txb_pass.Text = "";
                        txb_username.Text = "";
                        txb_Sphone.Text = "";
                        txb_posi.Text = "";
                        MessageBox.Show("User has been Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error occurd. Pleas try again...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Not Valid!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter User name & Password!", "Error");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                user.ID = txb_ID.Text;

                bool success = user.DeleteUser(user);
                dgv_user_info.DataSource = User.GetUser();
                if (success)
                {
                    txb_ID.Text = "";
                    txb_Fname.Text = "";
                    txb_Lname.Text = "";
                    txb_pass.Text = "";
                    txb_username.Text = "";
                    txb_Sphone.Text = "";
                    txb_posi.Text = "";

                    MessageBox.Show("User has been Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Row to Delete!");
            }
        }

        private void btn_Cear_Click(object sender, EventArgs e)
        {
            txb_ID.Text = "";
            txb_Fname.Text = "";
            txb_Lname.Text = "";
            txb_pass.Text = "";
            txb_username.Text = "";
            txb_Sphone.Text = "";
            txb_posi.Text = "";
        }

        private void dgv_user_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                txb_ID.Text = dgv_user_info.Rows[index].Cells[0].Value.ToString();
                txb_Fname.Text = dgv_user_info.Rows[index].Cells[1].Value.ToString();
                txb_Lname.Text = dgv_user_info.Rows[index].Cells[2].Value.ToString();
                txb_username.Text = dgv_user_info.Rows[index].Cells[3].Value.ToString();
                txb_pass.Text = dgv_user_info.Rows[index].Cells[4].Value.ToString();
                txb_posi.Text = dgv_user_info.Rows[index].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txb_Sphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("select * from Users where user_name='" + txb_username.Text + "'", con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        if (DR.HasRows)
                        {
                            var bmp = 
                            status_pic.Image = Resources.no;
                        }
                        else if (txb_username.Text.Trim() == "")
                        {
                            status_pic.Image = null;
                        }
                        else
                        {
                            status_pic.Image = Resources.yes;
                        }
                        
                    }

                }

            }
        }
    }
}
