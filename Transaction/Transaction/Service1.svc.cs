using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Transaction
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getIncome()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sum(amount) as total from Transactions where transactionType = @type";
            cmd.Parameters.AddWithValue("@type", "INCOME");
            SqlDataReader srdr = cmd.ExecuteReader();

            string income = "";

            if (srdr.Read())
            {

                income = srdr["total"].ToString();
            }

            conn.Close();

            return income;
        }

        public string getExpense()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sum(amount) as total from Transactions where transactionType = @type";
            cmd.Parameters.AddWithValue("@type", "EXPENSE");
            SqlDataReader srdr = cmd.ExecuteReader();


            string expenses = "";
            if (srdr.Read())
            {

                expenses = srdr["total"].ToString();
            }


            conn.Close();
            return expenses;

        }

        public string getBalance()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sum(amount) as total from Transactions";
            SqlDataReader srdr = cmd.ExecuteReader();


            string total = "";
            if (srdr.Read())
            {
                total = srdr["total"].ToString();
            }



            conn.Close();
            return total;
        }
        public string insertTransaction(Transaction transaction)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Transactions (transactionType,amount,description,source,paymentType) VALUES (@transactionType,@amount,@description,@source,@paymentType)";


            Console.WriteLine(cmd.CommandText);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.AddWithValue("@description", transaction.Description);
            cmd.Parameters.AddWithValue("@paymentType", transaction.PaymentType);
            cmd.Parameters.AddWithValue("@source", transaction.Source);
            cmd.Parameters.AddWithValue("@date", transaction.Date); ;
            cmd.Parameters.AddWithValue("@transactionType", transaction.TransactionType);

            int r = cmd.ExecuteNonQuery();
            // int r = 1;
            conn.Close();
            if (r > 0)
            {
                return "Successfully Added";
            }
            else
            {

                return "There was a problem";
            }

        }

        public string reset()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Transactions";

            int r = cmd.ExecuteNonQuery();

            if (r > 0)
            {
                return "Successfully Reseted!";
            }
            else
            {
                return "There was an Error!";
            }

        }

        public SqlDataReader getAllTransactions()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Transactions";

            return cmd.ExecuteReader();
        }

        public string UpdateTransaction(int id, Transaction transaction)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Transactions set amount=@amount,description=@description,source=@source,paymentType=@paymentType where Id=@id";


            Console.WriteLine(cmd.CommandText);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.AddWithValue("@description", transaction.Description);
            cmd.Parameters.AddWithValue("@paymentType", transaction.PaymentType);
            cmd.Parameters.AddWithValue("@source", transaction.Source);
            cmd.Parameters.AddWithValue("@Id", id); ;
            Console.WriteLine(cmd.CommandText);
            int r = cmd.ExecuteNonQuery();
            // int r = 1;
            conn.Close();

            if (r >= 1)
                return "Update Successfully!";
            else
                return "There was a problem!";
        }

        public string DeleteTransaction(int id)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpensesManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Transactions where Id = @id";
            cmd.Parameters.AddWithValue("@Id", id); ;

            int r = cmd.ExecuteNonQuery();
            // int r = 1;
            conn.Close();

            if (r >= 1)
                return "Delete Successfully!";
            else
                return "There was a problem!";

        }

    }
}

