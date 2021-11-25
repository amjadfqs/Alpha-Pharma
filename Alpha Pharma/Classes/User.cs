using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Pharma.Classes
{
    class User
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        private const string SelectQuery = "Select id as ID , user_name as Name, user_pass as Password, user_type as Type from Users";
        private const string InsertQuery = "Insert Into Users (user_name, user_pass, user_type) Values (@Name, @Password, @Type)";
        private const string UpdateQuery = "Update Users set user_name = @Name, user_pass = @Password, user_type = @Type where for_id = @ID";
        private const string DelectQuery = "Delete from Users where id = @ID";

        public static DataTable GeUser()
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


        public bool InsertForm(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Name", user.Name);
                    com.Parameters.AddWithValue("@Password", user.Password);
                    com.Parameters.AddWithValue("@Type", user.Type);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateForm(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", user.ID);
                    com.Parameters.AddWithValue("@Name", user.Name);
                    com.Parameters.AddWithValue("@Password", user.Password);
                    com.Parameters.AddWithValue("@Type", user.Type);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteForm(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DelectQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", user.ID);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public string loginChecker(string name, string pass)
        {
            string type = null;

            string select = "select * from Users where user_name=" + "'" + name + "'" + "and user_pass=" + "'" + pass + "'" ;

            using (SqlConnection con = new SqlConnection(myconn)) 
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(select, con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        if (DR.HasRows)     
                        {
                            while (DR.Read())
                            {
                                type = DR["user_type"].ToString();
                            }
                        }
                    }
                }
            }

            return type;
        }


    }
}
