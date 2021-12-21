using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class ReceiptDetails
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public int ID { get; set; }
        public string Rec_ID { get; set; }
        public string Pro_ID { get; set; }
        public string Pro_Price { get; set; }
        public string Pro_Qty { get; set; }

        private const string SelectQuery = "Select RD.rec_id as ReceID, R.emp_id EmpID, RD.pro_id as ProID, pro_price as UntiPrice, RD.pro_qty as QTY, (RD.pro_price*RD.pro_qty) As Total, rec_date as Date from Receipt_Detail as RD " +
                                           "Join Receipt as R on RD.rec_id = R.rec_id " +
                                           "join Products as P on RD.pro_id = P.pro_id " +
                                           "group by RD.rec_id , R.emp_id,RD.pro_id ,pro_price , pro_qty,R.rec_date " +
                                           "Order by R.rec_date";

        private const string InsertQuery =
            "Insert Into Receipt_Detail (rec_id, pro_id, pro_price, pro_qty) Values (@Rec_ID, @Pro_ID, @Pro_Price, @Pro_Qty)";


        private const string UpdateQty = "Update Store set pro_qty = (pro_qty - @Pro_Qty) where pro_id = @Pro_ID";


        public static DataTable GetReceiptDetail()
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

        public int InsertReceiptDetail(ReceiptDetails receiptDetails)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Rec_ID", receiptDetails.Rec_ID);
                    com.Parameters.AddWithValue("@Pro_ID", receiptDetails.Pro_ID);
                    com.Parameters.AddWithValue("@Pro_Price", receiptDetails.Pro_Price);
                    com.Parameters.AddWithValue("@Pro_Qty", receiptDetails.Pro_Qty);
                    rows = com.ExecuteNonQuery();
                }
            }

            return rows;
        }

        public bool UpdateProQty(ReceiptDetails receiptDetails)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQty, con))
                {
                    com.Parameters.AddWithValue("@Pro_ID", receiptDetails.Pro_ID);
                    com.Parameters.AddWithValue("@Pro_Qty", receiptDetails.Pro_Qty);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }



}

