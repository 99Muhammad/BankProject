namespace BankProject
{
    partial class frmTransaction
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
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_WithDrow = new System.Windows.Forms.Button();
            this.btn_TotalBalance = new System.Windows.Forms.Button();
            this.btn_MainMenue = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_TranferLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Deposit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deposit.Location = new System.Drawing.Point(82, 59);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(367, 68);
            this.btn_Deposit.TabIndex = 0;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_WithDrow
            // 
            this.btn_WithDrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WithDrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_WithDrow.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WithDrow.Location = new System.Drawing.Point(82, 153);
            this.btn_WithDrow.Name = "btn_WithDrow";
            this.btn_WithDrow.Size = new System.Drawing.Size(367, 68);
            this.btn_WithDrow.TabIndex = 1;
            this.btn_WithDrow.Text = "Withdrow";
            this.btn_WithDrow.UseVisualStyleBackColor = true;
            this.btn_WithDrow.Click += new System.EventHandler(this.btn_WithDrow_Click);
            // 
            // btn_TotalBalance
            // 
            this.btn_TotalBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TotalBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TotalBalance.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TotalBalance.Location = new System.Drawing.Point(82, 238);
            this.btn_TotalBalance.Name = "btn_TotalBalance";
            this.btn_TotalBalance.Size = new System.Drawing.Size(367, 68);
            this.btn_TotalBalance.TabIndex = 2;
            this.btn_TotalBalance.Text = "Total balances";
            this.btn_TotalBalance.UseVisualStyleBackColor = true;
            this.btn_TotalBalance.Click += new System.EventHandler(this.btn_TotalBalance_Click);
            // 
            // btn_MainMenue
            // 
            this.btn_MainMenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MainMenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MainMenue.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenue.Location = new System.Drawing.Point(82, 540);
            this.btn_MainMenue.Name = "btn_MainMenue";
            this.btn_MainMenue.Size = new System.Drawing.Size(367, 68);
            this.btn_MainMenue.TabIndex = 3;
            this.btn_MainMenue.Text = "Main menue";
            this.btn_MainMenue.UseVisualStyleBackColor = true;
            this.btn_MainMenue.Click += new System.EventHandler(this.btn_MainMenue_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Transfer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transfer.Location = new System.Drawing.Point(82, 440);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(367, 68);
            this.btn_Transfer.TabIndex = 4;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_TranferLog
            // 
            this.btn_TranferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TranferLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TranferLog.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TranferLog.Location = new System.Drawing.Point(82, 340);
            this.btn_TranferLog.Name = "btn_TranferLog";
            this.btn_TranferLog.Size = new System.Drawing.Size(367, 68);
            this.btn_TranferLog.TabIndex = 5;
            this.btn_TranferLog.Text = "Ttransfer Log";
            this.btn_TranferLog.UseVisualStyleBackColor = true;
            this.btn_TranferLog.Click += new System.EventHandler(this.btn_TranferLog_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 673);
            this.Controls.Add(this.btn_TranferLog);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_MainMenue);
            this.Controls.Add(this.btn_TotalBalance);
            this.Controls.Add(this.btn_WithDrow);
            this.Controls.Add(this.btn_Deposit);
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_WithDrow;
        private System.Windows.Forms.Button btn_TotalBalance;
        private System.Windows.Forms.Button btn_MainMenue;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_TranferLog;
    }
}