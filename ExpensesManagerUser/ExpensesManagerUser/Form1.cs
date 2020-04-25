using ExpensesManagerUser.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesManagerUser
{
    public partial class Form1 : Form
    {

        public int index = 0;
        public int flag = 1;
        public string transactionType = "";
        public Form1()
        {
          
            InitializeComponent();
        }

        public void loader()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            totalincome.Text = "Income :" + client.getIncome();
            totalexpenses.Text = "Expense : " + client.getExpense();
            totalbalance.Text = "Balance : " + client.getBalance();
           // this.Transactions_Click(null,null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loader();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = client.getAllTransactions().Tables[0];

        }

        private void Expenses_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Transaction transaction = new Transaction();
            transaction.Amount = Int32.Parse(amount.Text) * (-1);

            transaction.Date = date.ToString();
            transaction.Source = source.Text;
            transaction.Description = description.Text;
            transaction.PaymentType = type.Text;
            transaction.TransactionType = "EXPENSE";


            string r = client.insertTransaction(transaction);
            MessageBox.Show("Expense added Successfully!");
            loader();
        }

        private void Income_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Transaction transaction = new Transaction();
            transaction.Amount = Int32.Parse(amount.Text);

            transaction.Date = date.ToString();
            transaction.Source = source.Text;
            transaction.Description = description.Text;
            transaction.PaymentType = type.Text;
            transaction.TransactionType = "INCOME";


            string r = client.insertTransaction(transaction);
            MessageBox.Show("Income added Successfully !");
            loader();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string result = client.reset();
            MessageBox.Show(result);
            loader();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Transaction transaction = new Transaction();

            if (flag == -1)
            {
                transaction.Amount = Int32.Parse(amount.Text)*(-1);
               // MessageBox.Show(transactionType + transaction.Amount.ToString());
                flag = 1;
            }
            else
            {
                transaction.Amount = Int32.Parse(amount.Text);
               // MessageBox.Show(transactionType + transaction.Amount.ToString());
            }
            transaction.Date = date.ToString();
            transaction.Source = source.Text;
            transaction.Description = description.Text;
            transaction.PaymentType = type.Text;
            //Console.WriteLine("Amount + "+transaction.Amount);
            MessageBox.Show(client.UpdateTransaction(index, transaction));
            loader();
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            MessageBox.Show(client.DeleteTransaction(index));
            loader();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionType = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int amt = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (amt < 0)
            {
                flag = -1;
                amt = amt * (-1);
            }
          //  MessageBox.Show(amt.ToString());
            amount.Text = amt.ToString();
            source.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            description.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            type.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            index = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
