using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma
{
    class Supplier
    {
        private static string myConn =
            Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string Sup_id { get; set; }
        public string Sup_name { get; set; }
        public string Sup_address { get; set; }
        public string Sup_phone { get; set; }
        public string Suppplier_Desc { get; set; }

        private const string SelectQuery = "Select sup_id as ID , sup_name as Name ,sup_address as Address ,sup_phone as Phone,sup_desc as Description from Suppliers";
        private const string InsertQuery = "Insert Into Suppliers(sup_name, sup_address, sup_phone, sup_desc ) Values (@Sup_name ,@Sup_address , @Sup_phone, @Suppplier_Desc)";
        private const string UpdateQuery = "Update Suppliers set sup_name=@Sup_name , sup_address=@Sup_address, sup_phone=@Sup_phone, sup_desc=@Suppplier_Desc where sup_id=@Sup_id";
        private const string DeleteQuery = "Delete from Suppliers where sup_id=@Sup_id";

        public static DataTable GetSuppliers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertSupplier(Supplier supplier)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("Sup_name", supplier.Sup_name);
                    com.Parameters.AddWithValue("Sup_address", supplier.Sup_address);
                    com.Parameters.AddWithValue("Sup_phone", supplier.Sup_phone);
                    com.Parameters.AddWithValue("Suppplier_Desc", supplier.Suppplier_Desc);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            int rows;


            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("Sup_id", supplier.Sup_id);
                    com.Parameters.AddWithValue("Sup_name", supplier.Sup_name);
                    com.Parameters.AddWithValue("Sup_address", supplier.Sup_address);
                    com.Parameters.AddWithValue("Sup_phone", supplier.Sup_phone);
                    com.Parameters.AddWithValue("Suppplier_Desc", supplier.Suppplier_Desc);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool DeleteSupplier(Supplier supplier)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("Sup_id", supplier.Sup_id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}