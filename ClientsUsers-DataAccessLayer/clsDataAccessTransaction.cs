using Clients_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClientsUsers_DataAccessLayer
{
    public class clsDataAccessTransaction
    {
        public static bool InsertNewTransactionInfo(int clientID,
            float AmountOfDeposit,float AmountOfWithdrow,
            DateTime DateTimeOfTransction)
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO [dbo].[Transactions]
           ([ClientID],[AmountOfDeposit]
           ,[AmountOfWithdrow]
           ,[DateTimeOfTransction])
     VALUES
           (@ClientID,@AmountOfDeposit,@AmountOfWithdrow
           ,@DateTimeOfTransction)
            SELECT SCOPE_IDENTITY();";
            
            SqlCommand command1 = new SqlCommand(query, connection1);
            // command1.Parameters.AddWithValue("UserName", userName).Value = DBNull.Value;
            command1.Parameters.AddWithValue("@clientID", clientID);
            command1.Parameters.AddWithValue("@AmountOfDeposit", AmountOfDeposit);
            command1.Parameters.AddWithValue("@AmountOfWithdrow", AmountOfWithdrow);
            command1.Parameters.AddWithValue("@DateTimeOfTransction", DateTimeOfTransction);

           // bool isFound = false;
            int TransactionID = -1;
            try
            {
                connection1.Open();
                object result = command1.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Inserted))
                {
                    TransactionID = Inserted;
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
            return TransactionID!=-1;
        }

        public static DataTable GetAllBalances()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT [ClientID]
       [FirstName],[LastName],[AccountNumber],[Balance]
       FROM [dbo].[Clients]";

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
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

      public static float GetSumOfBalances()
        {
            return clsDataAccessClient.GetSumOfBalances();
        }

        public static bool SaveTranferInfo(int UserID,
            string Acc_NumberTransferfrom,string Acc_NumberTransferTo,
            float BalanceOfFromBeforeTransfer,float BalanceOfToBeforeTransfer,
         float BalanceOfFromAfterTransfer,float BalanceOfToafterTransfer,
         DateTime DateTimeOfTransfer)
        {
            SqlConnection connection1 = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"
            INSERT INTO [dbo].[TransferInfo]
           ([UserID],[AccNumberTransferfrom]
           ,[AccNumberTransferTo],[BalanceOfFromBeforeTransfer]
            ,[BalanceOfToBeforeTransfer],[BalanceOfFromAfterTransfer]
           ,[BalanceOfToafterTransfer] ,[DateTimeOfTransfer])
     VALUES
           (@UserID
           ,@AccNumberTransferfrom
           ,@AccNumberTransferTo
           ,@BalanceOfFromBeforeTransfer
           ,@BalanceOfToBeforeTransfer
           ,@BalanceOfFromAfterTransfer
           ,@BalanceOfToafterTransfer
           ,@DateTimeOfTransfer);
            SELECT SCOPE_IDENTITY();";

            SqlCommand command1 = new SqlCommand(query, connection1);
            // command1.Parameters.AddWithValue("UserName", userName).Value = DBNull.Value;
            command1.Parameters.AddWithValue("@UserID", UserID);
            command1.Parameters.AddWithValue("@AccNumberTransferfrom", Acc_NumberTransferfrom);
            command1.Parameters.AddWithValue("@AccNumberTransferTo", Acc_NumberTransferTo);
            command1.Parameters.AddWithValue("@BalanceOfFromBeforeTransfer", BalanceOfFromBeforeTransfer);
            command1.Parameters.AddWithValue("@BalanceOfFromAfterTransfer", BalanceOfFromAfterTransfer);
            command1.Parameters.AddWithValue("@BalanceOfToBeforeTransfer", BalanceOfToBeforeTransfer);
            command1.Parameters.AddWithValue("@BalanceOfToafterTransfer", BalanceOfToafterTransfer);
            //command1.Parameters.AddWithValue("@BalanceOfToafterTransfer", BalanceOfToafterTransfer);
            command1.Parameters.AddWithValue("@DateTimeOfTransfer", DateTimeOfTransfer);



            // bool isFound = false;
            int TransferID = -1;
            try
            {
                connection1.Open();
                object result = command1.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Inserted))
                {
                    TransferID = Inserted;
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
            return TransferID != -1;
        }


        public static DataTable GetAllTransfers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT [TransferID]
      ,[UserID]
      ,[AccNumberTransferfrom]
      ,[AccNumberTransferTo]
      ,[BalanceOfFromBeforeTransfer]
      ,[BalanceOfToBeforeTransfer]
      ,[BalanceOfFromAfterTransfer]
      ,[BalanceOfToafterTransfer]
      ,[DateTimeOfTransfer]
  FROM [dbo].[TransferInfo]";

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
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }


        public static bool DeleteTransactionByClientID(int ClientID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM[dbo].[Transactions]
            WHERE ClientID=@ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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
