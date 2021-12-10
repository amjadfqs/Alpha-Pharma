using System.Data;
using System.Data.SqlClient;

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

        private const string SelectQuery = "Select sec_id as SesssionID, E.emp_id as ID, E.emp_fname as Fname, E.emp_lname as Lname, Convert(VARCHAR, ses_start ,100) as SessionStart,Convert(VARCHAR, ses_end ,100) as SessionEnd, ses_description as SessionDescription from Sessions AS U " +
                                           "Join Employees AS E on U.emp_id = E.emp_id";
        private const string InsertQuery = "Insert Into Sessions (ses_start, ses_end, ses_description, emp_id) Values (@SessionStart, @SessionEnd, @SessionDescription, @ID)";
        private const string UpdateQuery = "Update Sessions set ses_start = @SessionStart, ses_end = @SessionEnd, ses_description = @SessionDescription where sec_id = @SessionID";
        private const string DeletQuery = "Delete from Sessions where sec_id = @SessionID";

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
                    com.Parameters.AddWithValue("@SessionEnd",session.SessionEnd);
                    com.Parameters.AddWithValue("@SessionDescription",session.SessionDescription);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
        public bool UpdatSession(Session session)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@SessionID", session.SessionID);
                    //com.Parameters.AddWithValue("@ID", session.ID);
                    com.Parameters.AddWithValue("@SessionStart", session.SessionStart);
                    com.Parameters.AddWithValue("@SessionEnd", session.SessionEnd);
                    com.Parameters.AddWithValue("@SessionDescription", session.SessionDescription);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool DeleteSession(Session session)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeletQuery, con))
                {
                    com.Parameters.AddWithValue("@SessionID", session.SessionID);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
    }
}
