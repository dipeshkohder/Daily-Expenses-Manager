namespace ExpensesManagerUser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalincome = new System.Windows.Forms.Label();
            this.totalexpenses = new System.Windows.Forms.Label();
            this.totalbalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.Button();
            this.expenses = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.source = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Expenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "All Transaction";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // totalincome
            // 
            this.totalincome.AutoSize = true;
            this.totalincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalincome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totalincome.Location = new System.Drawing.Point(21, 18);
            this.totalincome.Name = "totalincome";
            this.totalincome.Size = new System.Drawing.Size(87, 20);
            this.totalincome.TabIndex = 7;
            this.totalincome.Text = "Income : ";
            // 
            // totalexpenses
            // 
            this.totalexpenses.AutoSize = true;
            this.totalexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalexpenses.ForeColor = System.Drawing.Color.Red;
            this.totalexpenses.Location = new System.Drawing.Point(21, 47);
            this.totalexpenses.Name = "totalexpenses";
            this.totalexpenses.Size = new System.Drawing.Size(98, 20);
            this.totalexpenses.TabIndex = 8;
            this.totalexpenses.Text = "Expense : ";
            // 
            // totalbalance
            // 
            this.totalbalance.AutoSize = true;
            this.totalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalbalance.Location = new System.Drawing.Point(21, 76);
            this.totalbalance.Name = "totalbalance";
            this.totalbalance.Size = new System.Drawing.Size(95, 20);
            this.totalbalance.TabIndex = 9;
            this.totalbalance.Text = "Balance : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(418, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Daily Expenses Manager";
            // 
            // transactions
            // 
            this.transactions.Image = global::ExpensesManagerUser.Properties.Resources.transaction;
            this.transactions.Location = new System.Drawing.Point(347, 509);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(128, 124);
            this.transactions.TabIndex = 5;
            this.transactions.UseVisualStyleBackColor = true;
            this.transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // expenses
            // 
            this.expenses.Image = global::ExpensesManagerUser.Properties.Resources.expense;
            this.expenses.Location = new System.Drawing.Point(186, 509);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(131, 124);
            this.expenses.TabIndex = 2;
            this.expenses.UseVisualStyleBackColor = true;
            this.expenses.Click += new System.EventHandler(this.Expenses_Click);
            // 
            // income
            // 
            this.income.Image = global::ExpensesManagerUser.Properties.Resources.dollar1;
            this.income.Location = new System.Drawing.Point(26, 509);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(131, 124);
            this.income.TabIndex = 0;
            this.income.UseCompatibleTextRendering = true;
            this.income.UseVisualStyleBackColor = true;
            this.income.Click += new System.EventHandler(this.Income_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(39, 23);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 11;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.source);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.transactions);
            this.groupBox1.Controls.Add(this.amount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.expenses);
            this.groupBox1.Controls.Add(this.income);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 685);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Cheque",
            "Debit Card",
            "Other"});
            this.type.Location = new System.Drawing.Point(166, 396);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(249, 24);
            this.type.TabIndex = 24;
            // 
            // source
            // 
            this.source.FormattingEnabled = true;
            this.source.Items.AddRange(new object[] {
            "Business",
            "Loan",
            "Salary",
            "Clothing",
            "Drinks",
            "Education",
            "Food",
            "Fuel",
            "Fun",
            "Hospital",
            "Hostel",
            "Shooping",
            "Personal",
            "Tips",
            "Transport"});
            this.source.Location = new System.Drawing.Point(166, 107);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(249, 24);
            this.source.TabIndex = 23;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(166, 212);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(249, 154);
            this.description.TabIndex = 22;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(166, 52);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(249, 22);
            this.amount.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Type : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Description : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date :";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(166, 162);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 22);
            this.date.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.totalincome);
            this.groupBox2.Controls.Add(this.totalbalance);
            this.groupBox2.Controls.Add(this.totalexpenses);
            this.groupBox2.Location = new System.Drawing.Point(562, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 698);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(312, 644);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 37);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(164, 644);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 37);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(22, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "* For Update or Delete click corresponding row";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 473);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button expenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalincome;
        private System.Windows.Forms.Label totalexpenses;
        private System.Windows.Forms.Label totalbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label10;
    }
}

