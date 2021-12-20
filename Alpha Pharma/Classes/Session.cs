using System;
using System.Data;
using System.Data.SqlClient;
using Alpha_Pharma.Forms;

namespace Alpha_Pharma.Classes
{
    class Session
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string SessionID { get; set; }
        public string SessionStart { get; set; }
        public string SessionEnd { get; set; }
        public string SessionDescription { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }

        private const string SelectQuery = "Select E.emp_id as ID, E.emp_fname as Fname, E.emp_lname as Lname, Convert(VARCHAR, ses_start ,100) as SessionStart,Convert(VARCHAR, ses_end ,100) as SessionEnd,DateDiff(Hour,ses_start, ses_end) As Duration_in_Hour, DateDiff(Minute,ses_start, ses_end) As Duration_in_Minutes from Sessions AS U " +
                                           "Join Employees AS E on U.emp_id = E.emp_id";
        private const string InsertQuery = "Insert Into Sessions (ses_start, ses_end, emp_id) Values (@SessionStart, @SessionEnd, @ID)";
        // private const string UpdateQuery = "Update Sessions set ses_start = @SessionStart, ses_end = @SessionEnd where ses_id = @SessionID";
        // private const string DeletQuery = "Delete from Sessions where ses_id = @SessionID";

        public static DataTable GetSession()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public bool InsertSession(Session session)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", session.ID);
                    com.Parameters.AddWithValue("@SessionStart", session.SessionStart);
                    com.Parameters.AddWithValue("@SessionEnd", session.SessionEnd);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
       
    }
}
