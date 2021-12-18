using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma.Classes
{
    class User
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }

        public static string User_Name { get; set; }
        public static string User_Type { get; set; }
        public static int User_ID { get; set; }


        private const string SelectQuery = "Select E.emp_id as ID, E.emp_fname as Fname, E.emp_lname as Lname, user_name as UserName, user_pass as Password, user_type as Type from Users AS U " +
                                           "Join Employees AS E on U.emp_id = E.emp_id";
        private const string InsertQuery = "Insert Into Users (user_name, user_pass, user_type, emp_id) Values (@Name, @Password, @Type, @ID)";
        private const string UpdateQuery = "Update Users set user_name = @Name, user_pass = @Password, user_type = @Type where emp_id = @ID";
        private const string DelectQuery = "Delete from Users where emp_id = @ID";

        public static DataTable GetUser()
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


        public bool InsertUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", user.ID);
                    com.Parameters.AddWithValue("@Name", user.UserName);
                    com.Parameters.AddWithValue("@Password", user.Password);
                    com.Parameters.AddWithValue("@Type", user.Type);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@ID", user.ID);
                    com.Parameters.AddWithValue("@Name", user.UserName);
                    com.Parameters.AddWithValue("@Password", user.Password);
                    com.Parameters.AddWithValue("@Type", user.Type);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteUser(User user)
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
            int id = 0;
            string uname = null;

            // string select = "select * from Users where user_name=" + "'" + name + "'" + "and user_pass=" + "'" + pass + "'" ;
            string select = "select * from Users where user_name= @Name and user_pass= @Pass"  ;

            using (SqlConnection con = new SqlConnection(myconn)) 
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(select, con))
                {
                    com.Parameters.AddWithValue("@Name", name);
                    com.Parameters.AddWithValue("@Pass", pass);
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        if (DR.HasRows)
                        {
                            while (DR.Read())
                            {
                                type = DR["user_type"].ToString();
                                id = (int)DR["emp_id"];
                                uname = DR["user_name"].ToString();
                            }
                        }
                    }
                }
            }
            User_Name = uname;
            User_ID = id;
            User_Type = type;

            return type;
        }


    }
}
