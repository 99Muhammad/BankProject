using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClientsUsers_DataAccessLayer
{
    public class clsDataAccessUsers
    {
       static public int _AddUser( string userName,  string firstName,
           string lastName,string password,string phone, 
           string address,string imagePath, int permission,bool MarkForDelete=false)
        {
             
            SqlConnection connection1=new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @" INSERT INTO[dbo].[Users]
            ([UserName]
           , [FirstName]
           , [LastName]
           , [Password]
           , [Phone]
            ,[Permissions]
           , [Address]
           , [ImagePath]
           ,[MarkForDelete])
     VALUES
           ( @UserName
           , @FirstName
           , @LastName
           , @Password
           , @Phone
           ,@Permissions
           , @Address
           , @ImagePath
           ,@MarkForDelete);
            SELECT SCOPE_IDENTITY();";
     //       string query= @"INSERT INTO Users
     //      (UserName,FirstName,LastName,Password,Phone,Address,
     //       imagePath)
     //VALUES
     //      (@userName,@firstName,@lastName,@password,@phone,@address,
     //        @imagePath);
     //       SELECT SCOPE_IDENTITY();";

            SqlCommand command1 = new SqlCommand(query,connection1);
           // command1.Parameters.AddWithValue("UserName", userName).Value = DBNull.Value;
            command1.Parameters.AddWithValue("@UserName", userName);
            command1.Parameters.AddWithValue("@FirstName", firstName);
            command1.Parameters.AddWithValue("@LastName", lastName);
            command1.Parameters.AddWithValue("@Password", password);
            command1.Parameters.AddWithValue("@Phone", phone);
           command1.Parameters.AddWithValue("@Permissions", permission);
            command1.Parameters.AddWithValue("@Address", address);
            command1.Parameters.AddWithValue("@MarkForDelete", MarkForDelete);
            if (imagePath!=null && imagePath!="")
            {
                command1.Parameters.AddWithValue("@ImagePath", imagePath);
            }
            //else
            //{
            //    command1.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            //}
          
           // command1.Parameters.AddWithValue("@clientID", clientID);

            bool isFound = false;
            int ClientID = -1;
            try
            {
                connection1.Open();
                object result = command1.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Inserted))
                {
                   ClientID  = Inserted;
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
            return ClientID;
        }

        static public bool _UpdateUserInfo(string UserName,
              string Password,string Address,string FirstName,
              string LastName, string Phone,int Permission,
              string ImagePath)
        {
            bool isUpdate = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE [dbo].[Users]
   SET [UserName] = @UserName 
      ,[FirstName] =@FirstName
      ,[LastName] = @LastName
      ,[Password] = @Password
      ,[Phone] =    @Phone
     ,[Permissions]=@Permissions
      ,[Address] =  @Address
      ,[ImagePath] =@ImagePath

    WHERE [UserName] = @UserName and [Password] = @Password";
            //,[ClientID] =@ClientID
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("Permissions", Permission);
            command.Parameters.AddWithValue("Address", Address);
            command.Parameters.AddWithValue("ImagePath", ImagePath);
           // command.Parameters.AddWithValue("ClientID", clientID);


            try
            {
                connection.Open();
                int rowsAfeected = command.ExecuteNonQuery();
                isUpdate = rowsAfeected > 0;
            }
            catch(Exception ex)
            {
                isUpdate = false;
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
            return isUpdate;
        }


      static public bool Find(ref string UserName,
             ref string Password, ref string Address, ref string FirstName,
            ref string LastName,ref string Phone,ref int Permission,
            ref string ImagePath,ref int userID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from Users
                   where UserName=@UserName and Password=@Password and
                        MarkForDelete=0 ";

            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) 
                {
                    isFound = true;
                    userID = (int)reader["userID"];
                    Permission = (int)reader["Permissions"];
                    UserName =(string)reader["UserName"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Password= (string)reader["Password"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                   
                    if (reader["ImagePath"] ==System.DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }


                }
            }
            catch(Exception ex)
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

        static public bool IsUserExisting(string UserName,string Password)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from Users
                   where UserName=@UserName and Password=@Password
                and MarkForDelete=0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);

            try
            {
              

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            
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

        public static bool Delete(string UserName,string Password)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE [dbo].[Users]
            SET [MarkForDelete] = 1
                 WHERE UserName=@UserName and Password=@Password";

            //string query = @"DELETE FROM [dbo].[Users]
            //     WHERE UserName=@UserName and Password=@Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName",
                UserName);
            command.Parameters.AddWithValue("@Password",
               Password);

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

        public static DataTable GetAllUsers()
        {
            bool isFound = false;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM [dbo].[Users]
            where MarkForDelete =0 or MarkforDelete is null";

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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool InsertClientID(int ClientIDasForignKey)
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE [dbo].[Users]
            SET [ClientID] = @ClientID";
            //       string query= @"INSERT INTO Users
            //      (UserName,FirstName,LastName,Password,Phone,Address,
            //       imagePath)
            //VALUES
            //      (@userName,@firstName,@lastName,@password,@phone,@address,
            //        @imagePath);
            //       SELECT SCOPE_IDENTITY();";

            SqlCommand command1 = new SqlCommand(query, connection1);
            // command1.Parameters.AddWithValue("UserName", userName).Value = DBNull.Value;
            command1.Parameters.AddWithValue("@ClientID",
                ClientIDasForignKey);
          
            bool isFound = false;
            //int ClientID = -1;
            try
            {
              
                connection1.Open();
                object result = command1.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Inserted))
                {
                    ClientIDasForignKey = Inserted;
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

    }
}
