using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class For
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string FormName { get; set; }

        private const string SelectQuery = "Select for_id as ID , for_name as FormName from Forms";
        private const string InsertQuery = "Insert Into Forms (for_name) Values (@FormName)";
        private const string UpdateQuery = "Update Forms set for_name = @FormName where for_id = @ID";
        private const string DelectQuery = "Delete from Forms where for_id = @ID";

        public static DataTable GetForm()
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

        public bool InsertForm(For form)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@FormName", form.FormName);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }


        public bool UpdateForm(For form)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", form.ID);
                    com.Parameters.AddWithValue("@FormName", form.FormName);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteForm(For form)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DelectQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", form.ID);
                    com.Parameters.AddWithValue("@FormName", form.FormName);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
    }
}
