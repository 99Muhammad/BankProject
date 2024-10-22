namespace BankProject
{
    partial class frmAddAndUpdateUser
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
            this.lbl_Address = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lblLink_Remove = new System.Windows.Forms.LinkLabel();
            this.lblLink_SetImage = new System.Windows.Forms.LinkLabel();
            this.txt_uImagePath = new System.Windows.Forms.TextBox();
            this.txt_uPhones = new System.Windows.Forms.TextBox();
            this.txt_uLastName = new System.Windows.Forms.TextBox();
            this.txt_uAddress = new System.Windows.Forms.TextBox();
            this.txt_uFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uUserName = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_uPassword = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_Permissions = new System.Windows.Forms.CheckedListBox();
            this.btn_CheckedAll = new System.Windows.Forms.Button();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Registered = new System.Windows.Forms.CheckBox();
            this.chk_FindClient = new System.Windows.Forms.CheckBox();
            this.chk_ListClient = new System.Windows.Forms.CheckBox();
            this.chk_DeleteClient = new System.Windows.Forms.CheckBox();
            this.chk_UpdateClient = new System.Windows.Forms.CheckBox();
            this.chk_AddClient = new System.Windows.Forms.CheckBox();
            this.upictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Address
            // 
            this.lbl_Address.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Address.Location = new System.Drawing.Point(223, 38);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(644, 70);
            this.lbl_Address.TabIndex = 1;
            this.lbl_Address.Text = "Add new user screen";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Address.Click += new System.EventHandler(this.lbl_Address_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(322, 586);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(173, 64);
            this.btn_Close.TabIndex = 17;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(513, 586);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 64);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lblLink_Remove
            // 
            this.lblLink_Remove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink_Remove.Location = new System.Drawing.Point(1022, 181);
            this.lblLink_Remove.Name = "lblLink_Remove";
            this.lblLink_Remove.Size = new System.Drawing.Size(128, 34);
            this.lblLink_Remove.TabIndex = 52;
            this.lblLink_Remove.TabStop = true;
            this.lblLink_Remove.Text = "Remove";
            this.lblLink_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLink_SetImage
            // 
            this.lblLink_SetImage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink_SetImage.Location = new System.Drawing.Point(891, 181);
            this.lblLink_SetImage.Name = "lblLink_SetImage";
            this.lblLink_SetImage.Size = new System.Drawing.Size(125, 34);
            this.lblLink_SetImage.TabIndex = 15;
            this.lblLink_SetImage.TabStop = true;
            this.lblLink_SetImage.Text = "Set image ";
            this.lblLink_SetImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_uImagePath
            // 
            this.txt_uImagePath.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uImagePath.Location = new System.Drawing.Point(222, 521);
            this.txt_uImagePath.Name = "txt_uImagePath";
            this.txt_uImagePath.Size = new System.Drawing.Size(229, 33);
            this.txt_uImagePath.TabIndex = 6;
            this.txt_uImagePath.Tag = "";
            // 
            // txt_uPhones
            // 
            this.txt_uPhones.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uPhones.Location = new System.Drawing.Point(222, 399);
            this.txt_uPhones.Name = "txt_uPhones";
            this.txt_uPhones.Size = new System.Drawing.Size(229, 33);
            this.txt_uPhones.TabIndex = 4;
            this.txt_uPhones.Tag = "Phone";
            this.txt_uPhones.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserName_Validating);
            // 
            // txt_uLastName
            // 
            this.txt_uLastName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uLastName.Location = new System.Drawing.Point(222, 337);
            this.txt_uLastName.Name = "txt_uLastName";
            this.txt_uLastName.Size = new System.Drawing.Size(229, 33);
            this.txt_uLastName.TabIndex = 3;
            this.txt_uLastName.Tag = "Last Name";
            this.txt_uLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserName_Validating);
            // 
            // txt_uAddress
            // 
            this.txt_uAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uAddress.Location = new System.Drawing.Point(222, 457);
            this.txt_uAddress.Name = "txt_uAddress";
            this.txt_uAddress.Size = new System.Drawing.Size(229, 33);
            this.txt_uAddress.TabIndex = 5;
            this.txt_uAddress.Tag = "Address";
            this.txt_uAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserName_Validating);
            // 
            // txt_uFirstName
            // 
            this.txt_uFirstName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uFirstName.Location = new System.Drawing.Point(222, 276);
            this.txt_uFirstName.Name = "txt_uFirstName";
            this.txt_uFirstName.Size = new System.Drawing.Size(229, 33);
            this.txt_uFirstName.TabIndex = 2;
            this.txt_uFirstName.Tag = "First Name";
            this.txt_uFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserName_Validating);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(22, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 34);
            this.label7.TabIndex = 42;
            this.label7.Text = "Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(22, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 34);
            this.label5.TabIndex = 40;
            this.label5.Text = "Last Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(22, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 34);
            this.label4.TabIndex = 39;
            this.label4.Text = "Image Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(22, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(22, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 34);
            this.label2.TabIndex = 37;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_uUserName
            // 
            this.txt_uUserName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uUserName.Location = new System.Drawing.Point(222, 168);
            this.txt_uUserName.Name = "txt_uUserName";
            this.txt_uUserName.Size = new System.Drawing.Size(229, 33);
            this.txt_uUserName.TabIndex = 0;
            this.txt_uUserName.Tag = "UserName";
            // 
            // lbl_Username
            // 
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Username.Location = new System.Drawing.Point(22, 156);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(174, 34);
            this.lbl_Username.TabIndex = 54;
            this.lbl_Username.Text = "User name";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_uPassword
            // 
            this.txt_uPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uPassword.Location = new System.Drawing.Point(222, 225);
            this.txt_uPassword.Name = "txt_uPassword";
            this.txt_uPassword.Size = new System.Drawing.Size(229, 33);
            this.txt_uPassword.TabIndex = 1;
            this.txt_uPassword.Tag = "Password";
            this.txt_uPassword.TextChanged += new System.EventHandler(this.txt_uPassword_TextChanged);
            this.txt_uPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_uUserName_Validating);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Password.Location = new System.Drawing.Point(22, 222);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(185, 34);
            this.lbl_Password.TabIndex = 56;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_Permissions
            // 
            this.chk_Permissions.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Permissions.FormattingEnabled = true;
            this.chk_Permissions.Items.AddRange(new object[] {
            "Add new client ",
            "Update client information ",
            "Delete client information ",
            "List client information ",
            "Find client "});
            this.chk_Permissions.Location = new System.Drawing.Point(949, 12);
            this.chk_Permissions.Name = "chk_Permissions";
            this.chk_Permissions.Size = new System.Drawing.Size(304, 154);
            this.chk_Permissions.TabIndex = 57;
            // 
            // btn_CheckedAll
            // 
            this.btn_CheckedAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckedAll.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckedAll.Location = new System.Drawing.Point(508, 394);
            this.btn_CheckedAll.Name = "btn_CheckedAll";
            this.btn_CheckedAll.Size = new System.Drawing.Size(143, 46);
            this.btn_CheckedAll.TabIndex = 13;
            this.btn_CheckedAll.Text = "Check all ";
            this.btn_CheckedAll.UseVisualStyleBackColor = true;
            this.btn_CheckedAll.Click += new System.EventHandler(this.btn_CheckedAll_Click);
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveAll.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveAll.Location = new System.Drawing.Point(724, 394);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(143, 46);
            this.btn_RemoveAll.TabIndex = 14;
            this.btn_RemoveAll.Text = "Remove all";
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Registered);
            this.groupBox1.Controls.Add(this.chk_FindClient);
            this.groupBox1.Controls.Add(this.chk_ListClient);
            this.groupBox1.Controls.Add(this.chk_DeleteClient);
            this.groupBox1.Controls.Add(this.chk_UpdateClient);
            this.groupBox1.Controls.Add(this.chk_AddClient);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(491, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 206);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specify permissions";
            // 
            // chk_Registered
            // 
            this.chk_Registered.AutoSize = true;
            this.chk_Registered.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Registered.Location = new System.Drawing.Point(186, 147);
            this.chk_Registered.Name = "chk_Registered";
            this.chk_Registered.Size = new System.Drawing.Size(150, 26);
            this.chk_Registered.TabIndex = 12;
            this.chk_Registered.Tag = "64";
            this.chk_Registered.Text = "Registered list";
            this.chk_Registered.UseVisualStyleBackColor = true;
            this.chk_Registered.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // chk_FindClient
            // 
            this.chk_FindClient.AutoSize = true;
            this.chk_FindClient.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FindClient.Location = new System.Drawing.Point(17, 147);
            this.chk_FindClient.Name = "chk_FindClient";
            this.chk_FindClient.Size = new System.Drawing.Size(125, 26);
            this.chk_FindClient.TabIndex = 11;
            this.chk_FindClient.Tag = "32";
            this.chk_FindClient.Text = "Find client";
            this.chk_FindClient.UseVisualStyleBackColor = true;
            this.chk_FindClient.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // chk_ListClient
            // 
            this.chk_ListClient.AutoSize = true;
            this.chk_ListClient.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ListClient.Location = new System.Drawing.Point(186, 93);
            this.chk_ListClient.Name = "chk_ListClient";
            this.chk_ListClient.Size = new System.Drawing.Size(157, 26);
            this.chk_ListClient.TabIndex = 10;
            this.chk_ListClient.Tag = "16";
            this.chk_ListClient.Text = "List client info";
            this.chk_ListClient.UseVisualStyleBackColor = true;
            this.chk_ListClient.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // chk_DeleteClient
            // 
            this.chk_DeleteClient.AutoSize = true;
            this.chk_DeleteClient.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DeleteClient.Location = new System.Drawing.Point(17, 93);
            this.chk_DeleteClient.Name = "chk_DeleteClient";
            this.chk_DeleteClient.Size = new System.Drawing.Size(175, 26);
            this.chk_DeleteClient.TabIndex = 9;
            this.chk_DeleteClient.Tag = "8";
            this.chk_DeleteClient.Text = "Delete client info";
            this.chk_DeleteClient.UseVisualStyleBackColor = true;
            this.chk_DeleteClient.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // chk_UpdateClient
            // 
            this.chk_UpdateClient.AutoSize = true;
            this.chk_UpdateClient.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_UpdateClient.Location = new System.Drawing.Point(186, 41);
            this.chk_UpdateClient.Name = "chk_UpdateClient";
            this.chk_UpdateClient.Size = new System.Drawing.Size(181, 26);
            this.chk_UpdateClient.TabIndex = 7;
            this.chk_UpdateClient.Tag = "4";
            this.chk_UpdateClient.Text = "Update client info";
            this.chk_UpdateClient.UseVisualStyleBackColor = true;
            this.chk_UpdateClient.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // chk_AddClient
            // 
            this.chk_AddClient.AutoSize = true;
            this.chk_AddClient.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_AddClient.Location = new System.Drawing.Point(17, 41);
            this.chk_AddClient.Name = "chk_AddClient";
            this.chk_AddClient.Size = new System.Drawing.Size(157, 26);
            this.chk_AddClient.TabIndex = 7;
            this.chk_AddClient.Tag = "2";
            this.chk_AddClient.Text = "Add new client";
            this.chk_AddClient.UseVisualStyleBackColor = true;
            this.chk_AddClient.CheckedChanged += new System.EventHandler(this.chk_AddClient_CheckedChanged);
            // 
            // upictureBox1
            // 
            this.upictureBox1.Location = new System.Drawing.Point(916, 225);
            this.upictureBox1.Name = "upictureBox1";
            this.upictureBox1.Size = new System.Drawing.Size(256, 215);
            this.upictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upictureBox1.TabIndex = 50;
            this.upictureBox1.TabStop = false;
            // 
            // frmAddAndUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RemoveAll);
            this.Controls.Add(this.btn_CheckedAll);
            this.Controls.Add(this.chk_Permissions);
            this.Controls.Add(this.txt_uPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_uUserName);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lblLink_Remove);
            this.Controls.Add(this.lblLink_SetImage);
            this.Controls.Add(this.upictureBox1);
            this.Controls.Add(this.txt_uImagePath);
            this.Controls.Add(this.txt_uPhones);
            this.Controls.Add(this.txt_uLastName);
            this.Controls.Add(this.txt_uAddress);
            this.Controls.Add(this.txt_uFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Address);
            this.Name = "frmAddAndUpdateUser";
            this.Text = "frmAddAndUpdateUser";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.LinkLabel lblLink_Remove;
        private System.Windows.Forms.LinkLabel lblLink_SetImage;
        private System.Windows.Forms.PictureBox upictureBox1;
        private System.Windows.Forms.TextBox txt_uImagePath;
        private System.Windows.Forms.TextBox txt_uPhones;
        private System.Windows.Forms.TextBox txt_uLastName;
        private System.Windows.Forms.TextBox txt_uAddress;
        private System.Windows.Forms.TextBox txt_uFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uUserName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_uPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chk_Permissions;
        private System.Windows.Forms.Button btn_RemoveAll;
        private System.Windows.Forms.Button btn_CheckedAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_FindClient;
        private System.Windows.Forms.CheckBox chk_ListClient;
        private System.Windows.Forms.CheckBox chk_DeleteClient;
        private System.Windows.Forms.CheckBox chk_UpdateClient;
        private System.Windows.Forms.CheckBox chk_AddClient;
        private System.Windows.Forms.CheckBox chk_Registered;
    }
}