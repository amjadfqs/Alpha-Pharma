using System;
using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class Receipt
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public static int ID { get; set; } 
        public string Emp_ID { get; set; }
        public int Cus_ID { get; set; }
        public string QTY { get; set; }
        public float Total { get; set; }

        private const string SelectQuery = "Select * from Receipt";

        private const string InsertQuery = "Insert Into Receipt (emp_id, cus_id, rec_date, rec_total,qty) Values (@Emp_ID, @Cus_ID, Getdate(),@Total,@QTY); " +
                                           "Select Scope_Identity()";



        public static DataTable GetReceipt()
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

        public int InsertReceipt(Receipt receipt)
        {
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Emp_ID", receipt.Emp_ID);
                    com.Parameters.AddWithValue("@Cus_ID", receipt.Cus_ID);
                    com.Parameters.AddWithValue("@Total", receipt.Total);
                    com.Parameters.AddWithValue("@QTY", receipt.QTY);
                    ID = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            return ID;
        }
    }
}
