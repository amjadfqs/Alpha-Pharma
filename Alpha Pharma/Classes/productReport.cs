using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class productReport
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        private const string SelectExpieredProducts= "Select sto_id as StoreID,(pro_name + ' , ' + for_name + ' , ' + dos_qty) as DrugInfo, sup_name as SupplierName, pro_exp as Product_Expired , " +
                                                     "pro_price as Product_Price, pro_qty as Product_Quantity ,(pro_price*pro_qty) as Total_Price, pro_code as Product_Code from Store As S " +
                                                     "Join Products as P on S.pro_id = P.pro_id " +
                                                     "Join Suppliers as Sp on S.sup_id = Sp.sup_id " +
                                                     "join Forms as F on P.for_id = F.for_id " +
                                                     "join Doses as D on P.dos_id = D.dos_id where pro_exp <= Cast(getdate() as date)";

        private const string SelectValidProducts = "Select sto_id as StoreID,(pro_name + ' , ' + for_name + ' , ' + dos_qty) as DrugInfo, sup_name as SupplierName, pro_exp as Product_Expired , " +
                                                   "pro_price as Product_Price, pro_qty as Product_Quantity ,(pro_price*pro_qty) as Total_Price, pro_code as Product_Code from Store As S " +
                                                   "Join Products as P on S.pro_id = P.pro_id " +
                                                   "Join Suppliers as Sp on S.sup_id = Sp.sup_id " +
                                                   "join Forms as F on P.for_id = F.for_id " +
                                                   "join Doses as D on P.dos_id = D.dos_id where pro_exp >= Cast(getdate() as date)";

        private const string SelectAllProducts = "Select sto_id as StoreID,(pro_name + ' , ' + for_name + ' , ' + dos_qty) as DrugInfo, sup_name as SupplierName, pro_exp as Product_Expired , " +
                                                 "pro_price as Product_Price, pro_qty as Product_Quantity ,(pro_price*pro_qty) as Total_Price, pro_code as Product_Code from Store As S " +
                                                 "Join Products as P on S.pro_id = P.pro_id " +
                                                 "Join Suppliers as Sp on S.sup_id = Sp.sup_id " +
                                                 "join Forms as F on P.for_id = F.for_id " +
                                                 "join Doses as D on P.dos_id = D.dos_id";

        public static DataTable GetExpiredProduct()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectExpieredProducts, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public static DataTable GetValidProduct()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectValidProducts, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public static DataTable GetAllProduct()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectAllProducts, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }


}
