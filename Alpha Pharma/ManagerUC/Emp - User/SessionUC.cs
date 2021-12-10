using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Alpha_Pharma.Classes;
using Microsoft.VisualBasic;

namespace Alpha_Pharma.ManagerUC.Emp___User
{
    public partial class SessionUC : UserControl
    {
        private Session session = new Session();

        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        public SessionUC()
        {
            InitializeComponent();
            dgv_session_info.DataSource = Session.GetSession();
        }

        private void SessionUC_Load(object sender, EventArgs e)
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
                            // type = DR["user_type"].ToString();
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
                            while (DR.Read())
                            {
                                txb_ID.Text = DR.GetValue(0).ToString();
                                txb_Fname.Text = DR.GetValue(1).ToString();
                                txb_Lname.Text = DR.GetValue(2).ToString();
                            }
                        }
                    }
                }
            }
            else if (txb_Sphone.Text == "")
            {
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Enter only numbers!");
                txb_Sphone.Text = "";
                ClearControls();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            try
            {
                session.ID = txb_ID.Text;
                session.SessionStart = compo_ses_start.Text;
                session.SessionEnd = compo_ses_end.Text;
                session.SessionDescription = txb_ses_desc.Text;
                bool success = session.InsertSession(session);
                dgv_session_info.DataSource = Session.GetSession();
                if (success)
                {
                    MessageBox.Show(@"employee session has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You cannot add two session time with same TIme!", "Error exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void ClearControls()
        {
            txb_ID.Text = "";
            txb_Fname.Text = "";
            txb_Lname.Text = "";
            compo_ses_start.CustomFormat = " ";
            compo_ses_end.CustomFormat = " ";
            txb_ses_desc.Text = "";
            txb_Sphone.Text = "";
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                session.SessionID = lb_ses_id.Text;
                session.SessionStart = compo_ses_start.Text;
                session.SessionEnd = compo_ses_end.Text;
                session.SessionDescription = txb_ses_desc.Text;


                bool success = session.UpdatSession(session);
                dgv_session_info.DataSource = Session.GetSession();
                if (success)
                {


                    MessageBox.Show(@"employee session has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not Valid!");
            }

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            session.SessionID = lb_ses_id.Text;

            bool success = session.DeleteSession(session);
                dgv_session_info.DataSource = Session.GetSession();
                if (success)
                {
                    ClearControls();
                    MessageBox.Show("employee session has been Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error occurd. Pleas try again...");
                }
            
           
        }

        private void btn_Cear_Click(object sender, EventArgs e)
        {
            ClearControls();
            compo_ses_start.Format = DateTimePickerFormat.Custom;
            compo_ses_end.Format = DateTimePickerFormat.Custom;
        }

        private void compo_ses_start_MouseDown(object sender, MouseEventArgs e)
        {
            compo_ses_start.CustomFormat = "h:mm tt";
        }

        private void compo_ses_end_MouseDown(object sender, MouseEventArgs e)
        {
            compo_ses_end.CustomFormat = "h:mm tt";
        }

        private void dgv_session_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_ses_id.Text = dgv_session_info.Rows[index].Cells[0].Value.ToString();
                txb_ID.Text = dgv_session_info.Rows[index].Cells[1].Value.ToString();
                txb_Fname.Text = dgv_session_info.Rows[index].Cells[2].Value.ToString();
                txb_Lname.Text = dgv_session_info.Rows[index].Cells[3].Value.ToString();
                compo_ses_start.Text = dgv_session_info.Rows[index].Cells[4].Value.ToString();
                compo_ses_end.Text = dgv_session_info.Rows[index].Cells[5].Value.ToString();
                txb_ses_desc.Text = dgv_session_info.Rows[index].Cells[6].Value.ToString();
                compo_ses_start.Format = DateTimePickerFormat.Time;
                compo_ses_end.Format = DateTimePickerFormat.Time;
            }
            catch (Exception)
            {
                return;
            }
        }

     
    }
}
