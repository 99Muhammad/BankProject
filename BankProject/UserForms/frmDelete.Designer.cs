namespace BankProject
{
    partial class frmDelete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uDelete = new System.Windows.Forms.Button();
            this.btn_uClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_uShowdata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 117);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(250, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete user screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_uDelete
            // 
            this.btn_uDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uDelete.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uDelete.Location = new System.Drawing.Point(489, 393);
            this.btn_uDelete.Name = "btn_uDelete";
            this.btn_uDelete.Size = new System.Drawing.Size(171, 55);
            this.btn_uDelete.TabIndex = 2;
            this.btn_uDelete.Text = "Delete";
            this.btn_uDelete.UseVisualStyleBackColor = true;
            this.btn_uDelete.Click += new System.EventHandler(this.btn_uDelete_Click);
            // 
            // btn_uClose
            // 
            this.btn_uClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uClose.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uClose.Location = new System.Drawing.Point(257, 393);
            this.btn_uClose.Name = "btn_uClose";
            this.btn_uClose.Size = new System.Drawing.Size(171, 55);
            this.btn_uClose.TabIndex = 3;
            this.btn_uClose.Text = "Close";
            this.btn_uClose.UseVisualStyleBackColor = true;
            this.btn_uClose.Click += new System.EventHandler(this.btn_uClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter password";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(257, 137);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(229, 31);
            this.txt_UserName.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(257, 190);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(229, 31);
            this.txt_Password.TabIndex = 8;
            // 
            // btn_uShowdata
            // 
            this.btn_uShowdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uShowdata.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uShowdata.Location = new System.Drawing.Point(542, 153);
            this.btn_uShowdata.Name = "btn_uShowdata";
            this.btn_uShowdata.Size = new System.Drawing.Size(273, 45);
            this.btn_uShowdata.TabIndex = 9;
            this.btn_uShowdata.Text = "Enter to show data";
            this.btn_uShowdata.UseVisualStyleBackColor = true;
            this.btn_uShowdata.Click += new System.EventHandler(this.btn_uShowdata_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 456);
            this.Controls.Add(this.btn_uShowdata);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_uClose);
            this.Controls.Add(this.btn_uDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.Load += new System.EventHandler(this.frmDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uDelete;
        private System.Windows.Forms.Button btn_uClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_uShowdata;
    }
}