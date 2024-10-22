using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsUsers_DataAccessLayer
{
    public class clsDataAccessRegisterDate
    {
        public static bool InsertDateTimeWhenLogin(int userID,DateTime dateTime)
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO [dbo].[RegisterOprations]
           ([UserID]
           ,[DateTime])
     VALUES
           (@UserID,@DateTime);
            select SCOPE_IDENTITY();";

            //       string query = @"INSERT INTO [dbo].[RegisterOprations]
            //      ([UserID],[DateTime])
            //VALUES
            //      (@UserID,@DateTime)";


            SqlCommand command1 = new SqlCommand(query, connection1);

            command1.Parameters.AddWithValue("@UserID", userID);
            command1.Parameters.AddWithValue("@DateTime", dateTime);

            bool isFound = false;
            // int ClientID = -1;
            try
            {

                connection1.Open();
                object result = command1.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Inserted))
                {
                    //ClientIDasForignKey = Inserted;
                    isFound = true;
                }
                connection1.Close();
            }
            catch (Exception ex)
            {
                connection1.Close();

                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection1.Close();
            }
            //return ClientID;
            return isFound;
        }


        public static DataTable GetAllRegisteredInSystem()
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select RegisterOprations.RegisterID,
                    RegisterOprations.UserID,
                Users.FirstName,Users.LastName,
                Users.Permissions,Users.Phone,RegisterOprations.DateTime 
                from RegisterOprations inner join Users
                on Users.UserID=RegisterOprations.UserID";

            //       string query = @"INSERT INTO [dbo].[RegisterOprations]
            //      ([UserID],[DateTime])
            //VALUES
            //      (@UserID,@DateTime)";
            DataTable dt = new DataTable();

            SqlCommand command1 = new SqlCommand(query, connection1);

            // int ClientID = -1;
            try
            {

                connection1.Open();
                SqlDataReader reader = command1.ExecuteReader();

                if(reader!=null)
                {
                    dt.Load(reader);    
                }
                connection1.Close();
            }
            catch (Exception ex)
            {
                connection1.Close();

                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection1.Close();
            }
            //return ClientID;
            return dt;
        }

        public static int CountAllRegisteres()
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) from RegisterOprations;";
            SqlCommand command1 = new SqlCommand(query, connection1);

            int NumberOfregestred =0;
            try
            {

                connection1.Open();
                 NumberOfregestred =(int)command1.ExecuteScalar();
                
                connection1.Close();
            }
            catch (Exception ex)
            {
                connection1.Close();

                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection1.Close();
            }
            //return ClientID;
            return NumberOfregestred;
        }

        public static bool DeleteRegisteredByUserID(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            
                  string query = @"DELETE FROM[dbo].[RegisterOprations]
            WHERE UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID",UserID);
            

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
            return isFound;
        }
    }
}
