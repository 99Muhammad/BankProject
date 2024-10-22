namespace BankProject
{
    partial class frmTransfer
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
            this.txt_transferFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_FullNameFrom = new System.Windows.Forms.Label();
            this.lbl_AccNumberFrom = new System.Windows.Forms.Label();
            this.lbl_BalanceFrom = new System.Windows.Forms.Label();
            this.lbl_BalanceTo = new System.Windows.Forms.Label();
            this.lbl_AccNumberTo = new System.Windows.Forms.Label();
            this.lbl_FullNameTo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TransferTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TransferAmount = new System.Windows.Forms.TextBox();
            this.btn_PerformTransfer = new System.Windows.Forms.Button();
            this.btn_ShowInfoTo = new System.Windows.Forms.Button();
            this.btn_ShowInfoFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter account number you want trsansfer from : ";
            // 
            // txt_transferFrom
            // 
            this.txt_transferFrom.Location = new System.Drawing.Point(583, 130);
            this.txt_transferFrom.Name = "txt_transferFrom";
            this.txt_transferFrom.Size = new System.Drawing.Size(221, 26);
            this.txt_transferFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Acc.Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance       :";
            // 
            // lbl_FullNameFrom
            // 
            this.lbl_FullNameFrom.AutoSize = true;
            this.lbl_FullNameFrom.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullNameFrom.ForeColor = System.Drawing.Color.Green;
            this.lbl_FullNameFrom.Location = new System.Drawing.Point(179, 188);
            this.lbl_FullNameFrom.Name = "lbl_FullNameFrom";
            this.lbl_FullNameFrom.Size = new System.Drawing.Size(35, 30);
            this.lbl_FullNameFrom.TabIndex = 5;
            this.lbl_FullNameFrom.Text = "??";
            // 
            // lbl_AccNumberFrom
            // 
            this.lbl_AccNumberFrom.AutoSize = true;
            this.lbl_AccNumberFrom.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccNumberFrom.ForeColor = System.Drawing.Color.Green;
            this.lbl_AccNumberFrom.Location = new System.Drawing.Point(181, 239);
            this.lbl_AccNumberFrom.Name = "lbl_AccNumberFrom";
            this.lbl_AccNumberFrom.Size = new System.Drawing.Size(35, 30);
            this.lbl_AccNumberFrom.TabIndex = 6;
            this.lbl_AccNumberFrom.Text = "??";
            // 
            // lbl_BalanceFrom
            // 
            this.lbl_BalanceFrom.AutoSize = true;
            this.lbl_BalanceFrom.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalanceFrom.ForeColor = System.Drawing.Color.Green;
            this.lbl_BalanceFrom.Location = new System.Drawing.Point(178, 291);
            this.lbl_BalanceFrom.Name = "lbl_BalanceFrom";
            this.lbl_BalanceFrom.Size = new System.Drawing.Size(35, 30);
            this.lbl_BalanceFrom.TabIndex = 7;
            this.lbl_BalanceFrom.Text = "??";
            // 
            // lbl_BalanceTo
            // 
            this.lbl_BalanceTo.AutoSize = true;
            this.lbl_BalanceTo.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalanceTo.ForeColor = System.Drawing.Color.Green;
            this.lbl_BalanceTo.Location = new System.Drawing.Point(178, 533);
            this.lbl_BalanceTo.Name = "lbl_BalanceTo";
            this.lbl_BalanceTo.Size = new System.Drawing.Size(35, 30);
            this.lbl_BalanceTo.TabIndex = 15;
            this.lbl_BalanceTo.Text = "??";
            // 
            // lbl_AccNumberTo
            // 
            this.lbl_AccNumberTo.AutoSize = true;
            this.lbl_AccNumberTo.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccNumberTo.ForeColor = System.Drawing.Color.Green;
            this.lbl_AccNumberTo.Location = new System.Drawing.Point(181, 481);
            this.lbl_AccNumberTo.Name = "lbl_AccNumberTo";
            this.lbl_AccNumberTo.Size = new System.Drawing.Size(35, 30);
            this.lbl_AccNumberTo.TabIndex = 14;
            this.lbl_AccNumberTo.Text = "??";
            // 
            // lbl_FullNameTo
            // 
            this.lbl_FullNameTo.AutoSize = true;
            this.lbl_FullNameTo.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullNameTo.ForeColor = System.Drawing.Color.Green;
            this.lbl_FullNameTo.Location = new System.Drawing.Point(179, 430);
            this.lbl_FullNameTo.Name = "lbl_FullNameTo";
            this.lbl_FullNameTo.Size = new System.Drawing.Size(35, 30);
            this.lbl_FullNameTo.TabIndex = 13;
            this.lbl_FullNameTo.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(12, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Balance       :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(12, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "Acc.Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(12, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Full Name   :";
            // 
            // txt_TransferTo
            // 
            this.txt_TransferTo.Location = new System.Drawing.Point(583, 374);
            this.txt_TransferTo.Name = "txt_TransferTo";
            this.txt_TransferTo.Size = new System.Drawing.Size(221, 26);
            this.txt_TransferTo.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(12, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(531, 30);
            this.label11.TabIndex = 8;
            this.label11.Text = "Enter account number you want trsansfer to : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(12, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter transfer amount ?";
            // 
            // txt_TransferAmount
            // 
            this.txt_TransferAmount.Location = new System.Drawing.Point(304, 593);
            this.txt_TransferAmount.Name = "txt_TransferAmount";
            this.txt_TransferAmount.Size = new System.Drawing.Size(221, 26);
            this.txt_TransferAmount.TabIndex = 17;
            // 
            // btn_PerformTransfer
            // 
            this.btn_PerformTransfer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformTransfer.Location = new System.Drawing.Point(583, 583);
            this.btn_PerformTransfer.Name = "btn_PerformTransfer";
            this.btn_PerformTransfer.Size = new System.Drawing.Size(270, 48);
            this.btn_PerformTransfer.TabIndex = 18;
            this.btn_PerformTransfer.Text = "Perform transfer";
            this.btn_PerformTransfer.UseVisualStyleBackColor = true;
            this.btn_PerformTransfer.Click += new System.EventHandler(this.btn_PerformTransfer_Click);
            // 
            // btn_ShowInfoTo
            // 
            this.btn_ShowInfoTo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowInfoTo.Location = new System.Drawing.Point(814, 355);
            this.btn_ShowInfoTo.Name = "btn_ShowInfoTo";
            this.btn_ShowInfoTo.Size = new System.Drawing.Size(167, 61);
            this.btn_ShowInfoTo.TabIndex = 19;
            this.btn_ShowInfoTo.Text = "Show Info";
            this.btn_ShowInfoTo.UseVisualStyleBackColor = true;
            this.btn_ShowInfoTo.Click += new System.EventHandler(this.btn_ShowInfoTo_Click);
            // 
            // btn_ShowInfoFrom
            // 
            this.btn_ShowInfoFrom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowInfoFrom.Location = new System.Drawing.Point(814, 119);
            this.btn_ShowInfoFrom.Name = "btn_ShowInfoFrom";
            this.btn_ShowInfoFrom.Size = new System.Drawing.Size(154, 61);
            this.btn_ShowInfoFrom.TabIndex = 20;
            this.btn_ShowInfoFrom.Text = "Show info";
            this.btn_ShowInfoFrom.UseVisualStyleBackColor = true;
            this.btn_ShowInfoFrom.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 657);
            this.Controls.Add(this.btn_ShowInfoFrom);
            this.Controls.Add(this.btn_ShowInfoTo);
            this.Controls.Add(this.btn_PerformTransfer);
            this.Controls.Add(this.txt_TransferAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_BalanceTo);
            this.Controls.Add(this.lbl_AccNumberTo);
            this.Controls.Add(this.lbl_FullNameTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TransferTo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_BalanceFrom);
            this.Controls.Add(this.lbl_AccNumberFrom);
            this.Controls.Add(this.lbl_FullNameFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_transferFrom);
            this.Controls.Add(this.label1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_transferFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_FullNameFrom;
        private System.Windows.Forms.Label lbl_AccNumberFrom;
        private System.Windows.Forms.Label lbl_BalanceFrom;
        private System.Windows.Forms.Label lbl_BalanceTo;
        private System.Windows.Forms.Label lbl_AccNumberTo;
        private System.Windows.Forms.Label lbl_FullNameTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TransferTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TransferAmount;
        private System.Windows.Forms.Button btn_PerformTransfer;
        private System.Windows.Forms.Button btn_ShowInfoTo;
        private System.Windows.Forms.Button btn_ShowInfoFrom;
    }
}