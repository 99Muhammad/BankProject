
using ClientsUsers_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clients_DataAccessLayer
{
    public class clsDataAccessClient
    {
     public static int Save(string FirstName,string LastName,
            string AccountNumber,string PinCode,string Phone,
            float Balance,string Address,string ImagePath,int UserID)
        {

            int ContactID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Clients
           ([FirstName],[LastName],[AccountNumber],[PinCode]
           ,[Phone],[Balance],[Address],[ImagePath],[UserID])
     VALUES
           (@FirstName,@LastName,@AccountNumber,@PinCode,@Phone
           ,@Balance,@Address,@ImagePath,@UserID);
                 SELECT SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance",Balance);
            command.Parameters.AddWithValue("@Address",Address);
            command.Parameters.AddWithValue("@UserID", UserID);
            //       command.Parameters.AddWithValue("@ImagePath", ImagePath);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                //ContactID = 1;
               if(result!=null && int.TryParse(result.ToString(),out int Inserted))
                {
                    ContactID = Inserted;
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            finally
            {
                connection.Close();
            }
            return ContactID;

        }


        public static bool UpdateClientInfo( string FirstName,
             string LastName, string AccountNumber, 
             string PinCode,  string Phone, float Balance,
             string Address,  string ImagePath, int ClientID)
        {
            //bool isFound = false;
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Clients
   SET FirstName = @FirstName
      ,LastName = @LastName
      ,AccountNumber = @AccountNumber
      ,PinCode = @PinCode
      ,Phone = @Phone
      ,Balance = @Balance
      ,Address = @Address
      ,ImagePath = @ImagePath
      
             WHERE AccountNumber=@AccountNumber";

            SqlCommand command =new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@Address", Address);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            try
            {
                connection.Open();

                 rowsAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }


        public static bool FindClient(ref string FirstName,
            ref string LastName, ref string AccountNumber,
            ref string PinCode, ref string Phone, ref float Balance,
            ref string Address, ref string ImagePath,
            ref int ClientID)
       
        {
             bool isFound = false;
           // DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select *from Clients
                where AccountNumber=@AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber",AccountNumber);

            try
            {
                connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if(reader.Read())
                {
                     isFound = true;
                    //dt.Load(reader);
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    Phone = (string)reader["Phone"];
                    Balance = float.Parse(reader["Balance"].ToString());
                    Address = (string)reader["Address"];
                    if(reader["ImagePath"]==DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else {
                        ImagePath = (string)reader["ImagePath"]; 
                    }
                    
                    ClientID = (int)reader["ClientID"];

                }
                reader.Close();
                //isFound = (rowsAffected > 0);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool Delete(string AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM [dbo].[Clients]
                 WHERE AccountNumber=@AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber",
                AccountNumber);

            try
            {
                connection.Open();

              int rowsAffected=command.ExecuteNonQuery();

               
                isFound = (rowsAffected > 0);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static  DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "Select *from Clients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }


        public static float GetSumOfBalances()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @" SELECT Sum(Balance) 
              FROM [dbo].[Clients]";

            SqlCommand command = new SqlCommand(query, connection);
            float Sum = 0;
            try
            {
                connection.Open();

                object  result = command.ExecuteScalar();

                if (result!=null & float.TryParse(result.ToString(),out float inserted))
                {
                    Sum = inserted;
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Sum;
        }

        public static bool DeleteClientWithGivenUserID(int UserID, int ClientID)
        {
            bool isFound = false;
            if (clsDataAccessTransaction.DeleteTransactionByClientID(ClientID))
            {

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

                string query = @"DELETE FROM[dbo].[Clients]
            WHERE UserID=@UserID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();


                    isFound = (rowsAffected > 0);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }
              
            }
            return isFound;
        }
    }
}
