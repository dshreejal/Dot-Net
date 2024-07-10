using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//to connect with external data source system.data.sqlclient package is needed.
//to connect with sql server SqlConnection class is used and to execute the query SqlCommand class is used
//step to perform database operation
//1. import package system.data.sqclient
// 2. create connection string that contains all the necessary parameters like server name, database name and security
// 3. create object of SqlConnection class to connect  with server
// 4. open connection using open() method
// 5. write prooper sql query and handle sqkexception
// 6. execute the query by using SQlCommand class
// 7. close the connection

namespace DatabaseDemo
{
    class CRUD
    {
        private SqlConnection OpenConnection()
        {
            String server_name = "SHREEJALDHUNGAN";
            String dbname = "db_prime";
            String connectionString = $"Data Source={server_name};Initial Catalog={dbname};Integrated Security=true";
            // integrated security = true means windows authentication
            // if we want to use sql server authentication then we have to provide username and password
            // in exam, data source can be SERVER

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        public void createTable()
        {
            try {
                SqlConnection conn = OpenConnection();
                string tblQuery = "CREATE TABLE tbl_std  (" +
                    "id int primary key IDENTITY(1,1)," +
                    "name varchar(50)," +
                    "gender varchar(50)," +
                    "faculty varchar(50)," +
                    "fee varchar(50))";

                //executing query
                SqlCommand sc = new SqlCommand(tblQuery, conn);

                int res = sc.ExecuteNonQuery();
                
                Console.WriteLine(res+ "Table created successfully.");
            } catch (SqlException ex) {
                Console.WriteLine(ex);
            }
        }
        public void insertData()
        {
            try
            {
                SqlConnection conn = OpenConnection();

                string insertQuery = "INSERT INTO tbl_std (name, gender, faculty, fee)" +
                    " VALUES ('ram', 'male', 'CSIT', '20000' )";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, conn);

                int res = sqlCommand.ExecuteNonQuery();

                if(res > 0)
                {
                    Console.WriteLine("Data added successfully");
                }
                else
                {
                    Console.WriteLine(res + " Data insertion failed.");
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }  
        }
        public void insertUserData()
        {
            try
            {
                SqlConnection conn = OpenConnection();
   
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your gender: ");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter your faculty: ");
                string faculty = Console.ReadLine();

                Console.WriteLine("Enter your fee: ");
                string fee = Console.ReadLine();

                string insertQuery = "INSERT INTO tbl_std (name, gender, faculty, fee) " +
                    "VALUES (@name, @gender, @faculty, @fee)";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@faculty", faculty);
                sqlCommand.Parameters.AddWithValue("@fee", fee);

                int res = sqlCommand.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("Data Added Successfully");
                }
                else
                {
                    Console.WriteLine(res + "Data insertion failed.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void getAllData()
        {
            try {
                SqlConnection conn = OpenConnection();

                string fetchQuery = "SELECT * FROM tbl_std";

                // to fetch the  data, ExecuteReader is used.
                SqlCommand sc = new SqlCommand(fetchQuery, conn);

                SqlDataReader res = sc.ExecuteReader();

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Data from database:");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();

                while (res.Read())
                {
                    Console.WriteLine($"Id: {res["id"]}");
                    Console.WriteLine($"Name: {res["name"]}");
                    Console.WriteLine($"Gender: {res["gender"]}");
                    Console.WriteLine($"Faculty: {res["faculty"]}");
                    Console.WriteLine($"Fee: {res["fee"]}");
                    Console.WriteLine("--------------------------------------\n");
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void getDataById()
        {
            try
            {
                SqlConnection conn = OpenConnection();

                string fetchQuery = "SELECT * FROM tbl_std WHERE id=@id";
                SqlCommand sc = new SqlCommand(fetchQuery, conn);

                Console.Write("Enter id to get: ");
                int id = Convert.ToInt32(Console.ReadLine());
                sc.Parameters.AddWithValue("@id", id);

                SqlDataReader res = sc.ExecuteReader();
                while (res.Read())
                {
                    Console.WriteLine($"Id: {res["id"]}");
                    Console.WriteLine($"Name: {res["name"]}");
                    Console.WriteLine($"Gender: {res["gender"]}");
                    Console.WriteLine($"Faculty: {res["faculty"]}");
                    Console.WriteLine($"Fee: {res["fee"]}");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateData()
        {
            try
            {
                SqlConnection conn = OpenConnection();

                Console.Write("Enter the id of user you want to update: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new gender: ");
                string gender = Console.ReadLine();

                Console.Write("Enter new faculty: ");
                string faculty = Console.ReadLine();

                Console.Write("Enter new fee: ");
                float fee = float.Parse(Console.ReadLine());

                string updateQuery = "UPDATE tbl_std SET " +
                    "name=@name, gender=@gender, faculty=@faculty, fee=@fee " +
                    "WHERE id=@id";

                SqlCommand sc = new SqlCommand(updateQuery, conn);
                sc.Parameters.AddWithValue("@id", id);
                sc.Parameters.AddWithValue("@name", name);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@faculty", faculty);
                sc.Parameters.AddWithValue("@fee", fee);

                int res= sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data updated.");
                }
                else
                {
                    Console.WriteLine(res + "Failed to update data.");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteData()
        {
            try
            {
                SqlConnection conn = OpenConnection();

                string deleteQuery = "DELETE FROM tbl_std WHERE id=@id";

                Console.WriteLine("Enter the id to delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                SqlCommand sc = new SqlCommand(deleteQuery, conn);
                sc.Parameters.AddWithValue("@id", id);

                int res = sc.ExecuteNonQuery();

                if(res > 0)
                {
                    Console.WriteLine("Data deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No data found for the given id.");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
