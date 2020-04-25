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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string insertTransaction(Transaction transaction);

        [OperationContract]
        string getIncome();

        [OperationContract]
        string getExpense();
        [OperationContract]
        string getBalance();

        [OperationContract]

        string reset();

        [OperationContract]
        SqlDataReader getAllTransactions();

        [OperationContract]

        string UpdateTransaction(int id,Transaction transaction);

        [OperationContract]
        string DeleteTransaction(int id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Transaction
    {
        string transactionType = string.Empty;
        string date;
        int amount = 0;
        string description = string.Empty;
        string source = string.Empty;
        string paymentType = string.Empty;

        [DataMember]
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        [DataMember]
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        [DataMember]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        [DataMember]
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

    }
}
