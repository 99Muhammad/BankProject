namespace BankProject
{
    partial class frmUpdateUserInfo
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
            this.components = new System.ComponentModel.Container();
            this.txt_uUserNameUpdate = new System.Windows.Forms.TextBox();
            this.lbl_UsernameUpdate = new System.Windows.Forms.Label();
            this.txt_uPasswordUpdate = new System.Windows.Forms.TextBox();
            this.lbl_PasswordUpdate = new System.Windows.Forms.Label();
            this.btn_GoToUpdate = new System.Windows.Forms.Button();
            this.btn_closeUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_PasswordShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uUserNameUpdate
            // 
            this.txt_uUserNameUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uUserNameUpdate.Location = new System.Drawing.Point(309, 76);
            this.txt_uUserNameUpdate.Name = "txt_uUserNameUpdate";
            this.txt_uUserNameUpdate.Size = new System.Drawing.Size(229, 33);
            this.txt_uUserNameUpdate.TabIndex = 55;
            this.txt_uUserNameUpdate.Tag = "UserName";
            this.txt_uUserNameUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserNameUpdate_Validating);
            // 
            // lbl_UsernameUpdate
            // 
            this.lbl_UsernameUpdate.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsernameUpdate.ForeColor = System.Drawing.Color.Brown;
            this.lbl_UsernameUpdate.Location = new System.Drawing.Point(50, 68);
            this.lbl_UsernameUpdate.Name = "lbl_UsernameUpdate";
            this.lbl_UsernameUpdate.Size = new System.Drawing.Size(253, 34);
            this.lbl_UsernameUpdate.TabIndex = 56;
            this.lbl_UsernameUpdate.Text = "Enter user name";
            this.lbl_UsernameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_uPasswordUpdate
            // 
            this.txt_uPasswordUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uPasswordUpdate.Location = new System.Drawing.Point(309, 136);
            this.txt_uPasswordUpdate.Name = "txt_uPasswordUpdate";
            this.txt_uPasswordUpdate.Size = new System.Drawing.Size(229, 33);
            this.txt_uPasswordUpdate.TabIndex = 57;
            this.txt_uPasswordUpdate.Tag = "Password";
            this.txt_uPasswordUpdate.UseSystemPasswordChar = true;
            this.txt_uPasswordUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uPasswordUpdate_Validating);
            // 
            // lbl_PasswordUpdate
            // 
            this.lbl_PasswordUpdate.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordUpdate.ForeColor = System.Drawing.Color.Brown;
            this.lbl_PasswordUpdate.Location = new System.Drawing.Point(50, 128);
            this.lbl_PasswordUpdate.Name = "lbl_PasswordUpdate";
            this.lbl_PasswordUpdate.Size = new System.Drawing.Size(229, 34);
            this.lbl_PasswordUpdate.TabIndex = 58;
            this.lbl_PasswordUpdate.Text = "Enter password";
            this.lbl_PasswordUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GoToUpdate
            // 
            this.btn_GoToUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoToUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_GoToUpdate.Location = new System.Drawing.Point(309, 249);
            this.btn_GoToUpdate.Name = "btn_GoToUpdate";
            this.btn_GoToUpdate.Size = new System.Drawing.Size(153, 42);
            this.btn_GoToUpdate.TabIndex = 59;
            this.btn_GoToUpdate.Text = "Go to update";
            this.btn_GoToUpdate.UseVisualStyleBackColor = true;
            this.btn_GoToUpdate.Click += new System.EventHandler(this.btn_GoToUpdate_Click);
            // 
            // btn_closeUpdate
            // 
            this.btn_closeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_closeUpdate.Location = new System.Drawing.Point(113, 249);
            this.btn_closeUpdate.Name = "btn_closeUpdate";
            this.btn_closeUpdate.Size = new System.Drawing.Size(153, 42);
            this.btn_closeUpdate.TabIndex = 60;
            this.btn_closeUpdate.Text = "Close";
            this.btn_closeUpdate.UseVisualStyleBackColor = true;
            this.btn_closeUpdate.Click += new System.EventHandler(this.btn_closeUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_PasswordShow
            // 
            this.chk_PasswordShow.AutoSize = true;
            this.chk_PasswordShow.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_PasswordShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_PasswordShow.Location = new System.Drawing.Point(70, 181);
            this.chk_PasswordShow.Name = "chk_PasswordShow";
            this.chk_PasswordShow.Size = new System.Drawing.Size(176, 28);
            this.chk_PasswordShow.TabIndex = 61;
            this.chk_PasswordShow.Text = "Show paswword";
            this.chk_PasswordShow.UseVisualStyleBackColor = true;
            this.chk_PasswordShow.CheckedChanged += new System.EventHandler(this.chk_PasswordShow_CheckedChanged);
            // 
            // frmUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 303);
            this.Controls.Add(this.chk_PasswordShow);
            this.Controls.Add(this.btn_closeUpdate);
            this.Controls.Add(this.btn_GoToUpdate);
            this.Controls.Add(this.txt_uPasswordUpdate);
            this.Controls.Add(this.lbl_PasswordUpdate);
            this.Controls.Add(this.txt_uUserNameUpdate);
            this.Controls.Add(this.lbl_UsernameUpdate);
            this.Name = "frmUpdateUserInfo";
            this.Text = "frmUpdateUserInfo";
            this.Load += new System.EventHandler(this.frmUpdateUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_uUserNameUpdate;
        private System.Windows.Forms.Label lbl_UsernameUpdate;
        private System.Windows.Forms.TextBox txt_uPasswordUpdate;
        private System.Windows.Forms.Label lbl_PasswordUpdate;
        private System.Windows.Forms.Button btn_GoToUpdate;
        private System.Windows.Forms.Button btn_closeUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chk_PasswordShow;
    }
}