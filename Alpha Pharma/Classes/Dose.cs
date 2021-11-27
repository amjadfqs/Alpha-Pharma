using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class Dose
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string DoseQuantity { get; set; }

        private const string SelectQuery = "Select dos_id as ID , dos_qty as DoseQuantity from Doses";
        private const string InsertQuery = "Insert Into Doses (dos_qty) Values (@DoseQuantity)";
        private const string UpdateQuery = "Update Doses set dos_qty = @DoseQuantity where dos_id = @ID";
        private const string DelectQuery = "Delete from Doses where dos_id = @ID";


        public static DataTable GetDose()
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

        public bool InsertDose(Dose dose)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@DoseQuantity", dose.DoseQuantity);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateDose(Dose dose)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))   
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", dose.ID);
                    com.Parameters.AddWithValue("@DoseQuantity", dose.DoseQuantity);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteDose(Dose dose)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DelectQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", dose.ID);
                    com.Parameters.AddWithValue("@DoseQuantity", dose.DoseQuantity);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

    }
}
