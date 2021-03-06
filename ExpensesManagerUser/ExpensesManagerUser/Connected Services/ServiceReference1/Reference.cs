﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensesManagerUser.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/Transaction")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaymentTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentType {
            get {
                return this.PaymentTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PaymentTypeField, value) != true)) {
                    this.PaymentTypeField = value;
                    this.RaisePropertyChanged("PaymentType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransactionType {
            get {
                return this.TransactionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionTypeField, value) != true)) {
                    this.TransactionTypeField = value;
                    this.RaisePropertyChanged("TransactionType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertTransaction", ReplyAction="http://tempuri.org/IService1/insertTransactionResponse")]
        string insertTransaction(ExpensesManagerUser.ServiceReference1.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertTransaction", ReplyAction="http://tempuri.org/IService1/insertTransactionResponse")]
        System.Threading.Tasks.Task<string> insertTransactionAsync(ExpensesManagerUser.ServiceReference1.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getIncome", ReplyAction="http://tempuri.org/IService1/getIncomeResponse")]
        string getIncome();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getIncome", ReplyAction="http://tempuri.org/IService1/getIncomeResponse")]
        System.Threading.Tasks.Task<string> getIncomeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getExpense", ReplyAction="http://tempuri.org/IService1/getExpenseResponse")]
        string getExpense();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getExpense", ReplyAction="http://tempuri.org/IService1/getExpenseResponse")]
        System.Threading.Tasks.Task<string> getExpenseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getBalance", ReplyAction="http://tempuri.org/IService1/getBalanceResponse")]
        string getBalance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getBalance", ReplyAction="http://tempuri.org/IService1/getBalanceResponse")]
        System.Threading.Tasks.Task<string> getBalanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reset", ReplyAction="http://tempuri.org/IService1/resetResponse")]
        string reset();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reset", ReplyAction="http://tempuri.org/IService1/resetResponse")]
        System.Threading.Tasks.Task<string> resetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllTransactions", ReplyAction="http://tempuri.org/IService1/getAllTransactionsResponse")]
        System.Data.DataSet getAllTransactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllTransactions", ReplyAction="http://tempuri.org/IService1/getAllTransactionsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getAllTransactionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateTransaction", ReplyAction="http://tempuri.org/IService1/UpdateTransactionResponse")]
        string UpdateTransaction(int id, ExpensesManagerUser.ServiceReference1.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateTransaction", ReplyAction="http://tempuri.org/IService1/UpdateTransactionResponse")]
        System.Threading.Tasks.Task<string> UpdateTransactionAsync(int id, ExpensesManagerUser.ServiceReference1.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTransaction", ReplyAction="http://tempuri.org/IService1/DeleteTransactionResponse")]
        string DeleteTransaction(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTransaction", ReplyAction="http://tempuri.org/IService1/DeleteTransactionResponse")]
        System.Threading.Tasks.Task<string> DeleteTransactionAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ExpensesManagerUser.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ExpensesManagerUser.ServiceReference1.IService1>, ExpensesManagerUser.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string insertTransaction(ExpensesManagerUser.ServiceReference1.Transaction transaction) {
            return base.Channel.insertTransaction(transaction);
        }
        
        public System.Threading.Tasks.Task<string> insertTransactionAsync(ExpensesManagerUser.ServiceReference1.Transaction transaction) {
            return base.Channel.insertTransactionAsync(transaction);
        }
        
        public string getIncome() {
            return base.Channel.getIncome();
        }
        
        public System.Threading.Tasks.Task<string> getIncomeAsync() {
            return base.Channel.getIncomeAsync();
        }
        
        public string getExpense() {
            return base.Channel.getExpense();
        }
        
        public System.Threading.Tasks.Task<string> getExpenseAsync() {
            return base.Channel.getExpenseAsync();
        }
        
        public string getBalance() {
            return base.Channel.getBalance();
        }
        
        public System.Threading.Tasks.Task<string> getBalanceAsync() {
            return base.Channel.getBalanceAsync();
        }
        
        public string reset() {
            return base.Channel.reset();
        }
        
        public System.Threading.Tasks.Task<string> resetAsync() {
            return base.Channel.resetAsync();
        }
        
        public System.Data.DataSet getAllTransactions() {
            return base.Channel.getAllTransactions();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getAllTransactionsAsync() {
            return base.Channel.getAllTransactionsAsync();
        }
        
        public string UpdateTransaction(int id, ExpensesManagerUser.ServiceReference1.Transaction transaction) {
            return base.Channel.UpdateTransaction(id, transaction);
        }
        
        public System.Threading.Tasks.Task<string> UpdateTransactionAsync(int id, ExpensesManagerUser.ServiceReference1.Transaction transaction) {
            return base.Channel.UpdateTransactionAsync(id, transaction);
        }
        
        public string DeleteTransaction(int id) {
            return base.Channel.DeleteTransaction(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTransactionAsync(int id) {
            return base.Channel.DeleteTransactionAsync(id);
        }
    }
}
