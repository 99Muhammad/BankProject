using ClientsUsers_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsUsers_BussinessLayer
{
    public class clsTransaction:clsUsers
    {
        clsUsers user = new clsUsers();
        clsInfoForUserLogin infouser = new clsInfoForUserLogin();
      
        public int ClientID { get; set; }
        public float AmountOfDeposit { get; set; }
        public float AmountOfWithdrow { get; set; }
        public DateTime DateTimeOfTransction { get;set;} 


        public clsTransaction(int clientID,
            float AmountOfDeposit, float AmountOfWithdrow,
            DateTime DateTimeOfTransction)
        {
            this.ClientID = clientID;
            this.AmountOfDeposit = AmountOfDeposit;
            this.AmountOfWithdrow = AmountOfWithdrow;
            this.DateTimeOfTransction=DateTimeOfTransction;
        } 
        public clsTransaction()
        {

        }

        public bool InsertedNewTransaction
            (int clientID,
            float AmountOfDeposit, float AmountOfWithdrow,
            DateTime DateTimeOfTransction)
        {

            return clsDataAccessTransaction.InsertNewTransactionInfo
                (clientID,
                AmountOfDeposit, AmountOfWithdrow,
                DateTimeOfTransction);
        }


        public DataTable GetAllBalances()
        {
            return clsDataAccessTransaction.GetAllBalances();
        }

        public float GetSumOfBalances()
        {
            return clsDataAccessTransaction.GetSumOfBalances();
        }

        public bool SaveTransferInfo(string UserName,
            string Password,string AccNumFrom,string AccNumTo
            ,float BalanceBeforTranFrom, float BalanceBeforTranTo
            , float BalanceAfterTranFrom, float BalanceAfterTranTo)
        {
          clsUsers LoginUser= 
                clsUsers.Find(UserName,
                Password);
          return clsDataAccessTransaction.SaveTranferInfo
                (LoginUser.UserID, AccNumFrom, AccNumTo,
                BalanceBeforTranFrom, BalanceBeforTranTo,
                BalanceAfterTranFrom, BalanceAfterTranTo,
                DateTime.Now);

        }

        public  DataTable GetAllTransfers()
        {
            return clsDataAccessTransaction.GetAllTransfers();
        }
      

    }
}
