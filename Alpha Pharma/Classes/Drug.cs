using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class Drug
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string ID { get; set; }
        public string DrugName { get; set; }
        public string Section { get; set; }
        public string Form { get; set; }
        public string Dose { get; set; }

        private const string SelectQuery =
            "select pro_id as ID, pro_name as DrugName, S.sec_name as Section, F.for_name as Form, D.dos_qty as Dose , (pro_name + ' , ' + F.for_name + ' , ' + D.dos_qty) as DrugAll " +
            "from Products AS P " +
            "Join Sections AS S ON P.sec_id = S.sec_id " +
            "Join Forms AS F ON P.for_id = F.for_id " +
            "Join Doses AS D ON P.dos_id = D.dos_id ";


        private const string InsertQuery = "Insert Into Products(pro_name, sec_id, for_id, dos_id ) Values (@DrugName,@Section,@Form,@Dose)";

        private const string UpdateQuery = "Update Products set pro_name = @DrugName, " +
                                           "sec_id =  @Section," +
                                           "for_id =  @Form, " +
                                           "dos_id =  @Dose " +
                                           "where pro_id = @ID";
        
        private const string DeleteQuery = "Delete from Products where pro_id = @ID";


        public static DataTable GetDrug()
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

        public bool InsertDrug(Drug drug)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@DrugName", drug.DrugName);
                    com.Parameters.AddWithValue("@Section", drug.Section);
                    com.Parameters.AddWithValue("@Form", drug.Form);
                    com.Parameters.AddWithValue("@Dose", drug.Dose);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateDrug(Drug drug)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", drug.ID);
                    com.Parameters.AddWithValue("@DrugName", drug.DrugName);
                    com.Parameters.AddWithValue("@Section", drug.Section);
                    com.Parameters.AddWithValue("@Form", drug.Form);
                    com.Parameters.AddWithValue("@Dose", drug.Dose);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool DeleteDrug(Drug drug)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", drug.ID);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

    }
}
