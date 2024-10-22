namespace BankProject
{
    partial class frmRegisters
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
            this.lbl_NumberOfRregistered = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(258, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register screen ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NumberOfRregistered
            // 
            this.lbl_NumberOfRregistered.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfRregistered.ForeColor = System.Drawing.Color.Green;
            this.lbl_NumberOfRregistered.Location = new System.Drawing.Point(25, 120);
            this.lbl_NumberOfRregistered.Name = "lbl_NumberOfRregistered";
            this.lbl_NumberOfRregistered.Size = new System.Drawing.Size(88, 37);
            this.lbl_NumberOfRregistered.TabIndex = 1;
            this.lbl_NumberOfRregistered.Text = "?? ";
            this.lbl_NumberOfRregistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Green;
            this.label22.Location = new System.Drawing.Point(131, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(174, 37);
            this.label22.TabIndex = 2;
            this.label22.Text = "Record(s)";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbl_NumberOfRregistered);
            this.Controls.Add(this.label1);
            this.Name = "frmRegisters";
            this.Text = "frmRegisters";
            this.Load += new System.EventHandler(this.frmRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NumberOfRregistered;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}