using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class Store
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string Pro_ID { get; set; }
        public string Sup_ID { get; set; }
        public string Pro_Expire { get; set; }
        public string Pro_Price { get; set; }
        public string Pro_Qty { get; set; }
        public string Pro_Code { get; set; }

        private const string SelectQuery = "Select sto_id as StoreID, pro_name as DrugName,for_name as Form, sup_name as SupplierName, pro_exp as Product_Expired , " +
                                           "pro_price as Product_Price, pro_qty as Product_Quantity ,(pro_price*pro_qty) as Total_Price, pro_code as Product_Code from Store As S " +
                                           "Join Products as P on S.pro_id = P.pro_id " +
                                           "Join Suppliers as Sp on S.sup_id = Sp.sup_id " +
                                           "join Forms as F on P.for_id = F.for_id";

        private const string InsertQuery = "Insert Into Store (pro_id,sup_id,pro_exp,pro_price,pro_qty,pro_code)" +
                                           " Values (@Pro_ID,@Sup_ID,@Pro_Expire,@Pro_Price,@Pro_Qty,@Pro_Code) ";

        public static DataTable GetStore()
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

        public bool InsertStore(Store store)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Pro_ID", store.Pro_ID);
                    com.Parameters.AddWithValue("@SUp_ID", store.Sup_ID);
                    com.Parameters.AddWithValue("@Pro_Expire", store.Pro_Expire);
                    com.Parameters.AddWithValue("@Pro_Price", store.Pro_Price);
                    com.Parameters.AddWithValue("@Pro_Qty", store.Pro_Qty);
                    com.Parameters.AddWithValue("@Pro_Code", store.Pro_Code);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
