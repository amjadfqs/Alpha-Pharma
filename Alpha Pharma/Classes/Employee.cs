using System.Data;
using System.Data.SqlClient;

namespace Alpha_Pharma
{
    class Employee
    {
        private static string employeeConn = Properties.Settings.Default.Pharmacy_dbConnectionString;
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Salary { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Dob { get; set; }
        public string Created_At { get; set; }
        public int TimeUpdated { get; set; }


        //select
        private const string SelectQuery =
            "Select emp_id as Id, emp_fname as FName," +
            " emp_lname as LName, emp_salary as Salary, emp_phone as Phone," +
            "emp_email as Email, emp_sex as Gender," +
            " emp_position as Position, emp_dob as DOB," +
            " created_at as Created_At, updated_at as Updated_At," +
            " update_time as TimeUpdated from Employees";
        //insert
        private const string InsertQuery =
            "Insert Into Employees(emp_fname, emp_lname, emp_salary, emp_phone, emp_email, emp_sex, emp_position, emp_dob, created_at, update_time) Values " +
            "(@FName, @LName, @Salary, @Phone, @Email, @Gender, @Position, @DOB,  Cast(GETDATE() as Date), 0)";
        //Update
        private const string UpdateQuery =
            "Update Employees set emp_fname=@FName, emp_lname=@LName, emp_salary=@Salary, " +
            "emp_phone=@Phone, emp_email=@Email, emp_sex=@Gender, emp_position=@Position, emp_dob=@DOB," +
            " updated_at = Cast(GETDATE() as Date) , update_time = update_time + 1" +
            " where emp_id=@Id";
        //delete
        private const string DeleteQuery = "Delete from Employees where emp_id=@Id";

        public static DataTable GetEmployees()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(employeeConn))
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

        public bool InsertEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(employeeConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@FName", employee.FName);
                    com.Parameters.AddWithValue("@LName", employee.LName);
                    com.Parameters.AddWithValue("@Salary", employee.Salary);
                    com.Parameters.AddWithValue("@Phone", employee.Phone);
                    com.Parameters.AddWithValue("@Email", employee.Email);
                    com.Parameters.AddWithValue("@Gender", employee.Gender);
                    com.Parameters.AddWithValue("@Position", employee.Position);
                    com.Parameters.AddWithValue("@DOB", employee.Dob);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(employeeConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@Id", employee.Id);
                    com.Parameters.AddWithValue("@FName", employee.FName);
                    com.Parameters.AddWithValue("@LName", employee.LName);
                    com.Parameters.AddWithValue("@Salary", employee.Salary);
                    com.Parameters.AddWithValue("@Phone", employee.Phone);
                    com.Parameters.AddWithValue("@Email", employee.Email);
                    com.Parameters.AddWithValue("@Gender", employee.Gender);
                    com.Parameters.AddWithValue("@Position", employee.Position);
                    com.Parameters.AddWithValue("@DOB", employee.Dob);
                    rows = com.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }
        public bool DeleteEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(employeeConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("Id", employee.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

    }
}
