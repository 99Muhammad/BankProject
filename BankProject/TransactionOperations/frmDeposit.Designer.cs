namespace BankProject
{
    partial class frmDepositAndWithDrow
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
            this.txt_SearchByAccounyNumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_LoadClientData = new System.Windows.Forms.Button();
            this.txt_DepositAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_PerformTransaction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter account number";
            // 
            // txt_SearchByAccounyNumber
            // 
            this.txt_SearchByAccounyNumber.Location = new System.Drawing.Point(336, 107);
            this.txt_SearchByAccounyNumber.Name = "txt_SearchByAccounyNumber";
            this.txt_SearchByAccounyNumber.Size = new System.Drawing.Size(210, 26);
            this.txt_SearchByAccounyNumber.TabIndex = 1;
            this.txt_SearchByAccounyNumber.TextChanged += new System.EventHandler(this.txt_SearchByAccounyNumber_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 136);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_LoadClientData
            // 
            this.btn_LoadClientData.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadClientData.Location = new System.Drawing.Point(594, 93);
            this.btn_LoadClientData.Name = "btn_LoadClientData";
            this.btn_LoadClientData.Size = new System.Drawing.Size(259, 40);
            this.btn_LoadClientData.TabIndex = 3;
            this.btn_LoadClientData.Text = "Load client info";
            this.btn_LoadClientData.UseVisualStyleBackColor = true;
            this.btn_LoadClientData.Click += new System.EventHandler(this.btn_LoadClientData_Click);
            // 
            // txt_DepositAmount
            // 
            this.txt_DepositAmount.Location = new System.Drawing.Point(406, 330);
            this.txt_DepositAmount.Name = "txt_DepositAmount";
            this.txt_DepositAmount.Size = new System.Drawing.Size(210, 26);
            this.txt_DepositAmount.TabIndex = 5;
            this.txt_DepositAmount.TextChanged += new System.EventHandler(this.txt_DepositAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please,enter an amount ?";
            // 
            // chk_PerformTransaction
            // 
            this.chk_PerformTransaction.AutoSize = true;
            this.chk_PerformTransaction.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_PerformTransaction.Location = new System.Drawing.Point(18, 371);
            this.chk_PerformTransaction.Name = "chk_PerformTransaction";
            this.chk_PerformTransaction.Size = new System.Drawing.Size(539, 29);
            this.chk_PerformTransaction.TabIndex = 6;
            this.chk_PerformTransaction.Text = "Check if you sure you want to perform transaction?";
            this.chk_PerformTransaction.UseVisualStyleBackColor = true;
            this.chk_PerformTransaction.CheckedChanged += new System.EventHandler(this.chk_PerformTransaction_CheckedChanged);
            // 
            // frmDepositAndWithDrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 589);
            this.Controls.Add(this.chk_PerformTransaction);
            this.Controls.Add(this.txt_DepositAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_LoadClientData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SearchByAccounyNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmDepositAndWithDrow";
            this.Text = "frmDepositAndWithDrow";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchByAccounyNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_LoadClientData;
        private System.Windows.Forms.TextBox txt_DepositAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_PerformTransaction;
    }
}