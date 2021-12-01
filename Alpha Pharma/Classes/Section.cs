using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class Section
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string SectionName { get; set; }

        private const string SelectQuery = "Select sec_id as ID , sec_name as SectionName from Sections";
        private const string InsertQuery = "Insert Into Sections (sec_name) Values (@SectionName)";
        private const string UpdateQuery = "Update Sections set sec_name = @SectionName where sec_id = @ID";
        private const string DelectQuery = "Delete from Sections where sec_id = @ID";

        public static DataTable GetSection()
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

        public bool InsertSection(Section section)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@SectionName", section.SectionName);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateSection(Section section)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", section.ID);
                    com.Parameters.AddWithValue("@SectionName", section.SectionName);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteSection(Section section)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DelectQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", section.ID);
                    com.Parameters.AddWithValue("@SectionName", section.SectionName);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
    }
}
