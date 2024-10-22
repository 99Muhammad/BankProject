namespace BankProject
{
    partial class frmUsersMainMenue
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
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_ListUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateUser.FlatAppearance.BorderSize = 0;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_UpdateUser.Image = global::BankProject.Properties.Resources.live_update;
            this.btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateUser.Location = new System.Drawing.Point(12, 183);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(311, 54);
            this.btn_UpdateUser.TabIndex = 5;
            this.btn_UpdateUser.Text = "Update user info";
            this.btn_UpdateUser.UseVisualStyleBackColor = true;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_DeleteUser.Image = global::BankProject.Properties.Resources.delete;
            this.btn_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteUser.Location = new System.Drawing.Point(12, 273);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(311, 54);
            this.btn_DeleteUser.TabIndex = 3;
            this.btn_DeleteUser.Text = "Delete user";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_ListUser
            // 
            this.btn_ListUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListUser.FlatAppearance.BorderSize = 0;
            this.btn_ListUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ListUser.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListUser.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_ListUser.Image = global::BankProject.Properties.Resources.attendance_list;
            this.btn_ListUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListUser.Location = new System.Drawing.Point(12, 363);
            this.btn_ListUser.Name = "btn_ListUser";
            this.btn_ListUser.Size = new System.Drawing.Size(311, 54);
            this.btn_ListUser.TabIndex = 2;
            this.btn_ListUser.Text = "List user";
            this.btn_ListUser.UseVisualStyleBackColor = true;
            this.btn_ListUser.Click += new System.EventHandler(this.btn_ListUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.FlatAppearance.BorderSize = 0;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddUser.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_AddUser.Image = global::BankProject.Properties.Resources.add;
            this.btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUser.Location = new System.Drawing.Point(12, 93);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(311, 54);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add new user";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // frmUsersMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 495);
            this.Controls.Add(this.btn_UpdateUser);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_ListUser);
            this.Controls.Add(this.btn_AddUser);
            this.Name = "frmUsersMainMenue";
            this.Text = "frmUsersMainMenue";
            this.Load += new System.EventHandler(this.frmUsersMainMenue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_ListUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_UpdateUser;
    }
}