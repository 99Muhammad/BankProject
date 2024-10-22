namespace BankProject
{
    partial class ctrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_uImagePath = new System.Windows.Forms.TextBox();
            this.txt_uPermission = new System.Windows.Forms.TextBox();
            this.txt_uPassword = new System.Windows.Forms.TextBox();
            this.txt_uPhone = new System.Windows.Forms.TextBox();
            this.txt_uLastName = new System.Windows.Forms.TextBox();
            this.txt_uAddress = new System.Windows.Forms.TextBox();
            this.txt_uFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1_User = new System.Windows.Forms.ErrorProvider(this.components);
            this.upictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLink_SetImage = new System.Windows.Forms.LinkLabel();
            this.lblLink_Remove = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uImagePath
            // 
            this.txt_uImagePath.Location = new System.Drawing.Point(218, 420);
            this.txt_uImagePath.Name = "txt_uImagePath";
            this.txt_uImagePath.Size = new System.Drawing.Size(229, 26);
            this.txt_uImagePath.TabIndex = 32;
            this.txt_uImagePath.Tag = "";
            // 
            // txt_uPermission
            // 
            this.txt_uPermission.Location = new System.Drawing.Point(218, 359);
            this.txt_uPermission.Name = "txt_uPermission";
            this.txt_uPermission.Size = new System.Drawing.Size(229, 26);
            this.txt_uPermission.TabIndex = 30;
            this.txt_uPermission.Tag = "Permission";
            this.txt_uPermission.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_uPassword
            // 
            this.txt_uPassword.Location = new System.Drawing.Point(218, 227);
            this.txt_uPassword.Name = "txt_uPassword";
            this.txt_uPassword.Size = new System.Drawing.Size(229, 26);
            this.txt_uPassword.TabIndex = 29;
            this.txt_uPassword.Tag = "Password";
            this.txt_uPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_uPhone
            // 
            this.txt_uPhone.Location = new System.Drawing.Point(218, 166);
            this.txt_uPhone.Name = "txt_uPhone";
            this.txt_uPhone.Size = new System.Drawing.Size(229, 26);
            this.txt_uPhone.TabIndex = 28;
            this.txt_uPhone.Tag = "Phone";
            this.txt_uPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_uLastName
            // 
            this.txt_uLastName.Location = new System.Drawing.Point(218, 104);
            this.txt_uLastName.Name = "txt_uLastName";
            this.txt_uLastName.Size = new System.Drawing.Size(229, 26);
            this.txt_uLastName.TabIndex = 27;
            this.txt_uLastName.Tag = "Last Name";
            this.txt_uLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_uAddress
            // 
            this.txt_uAddress.Location = new System.Drawing.Point(218, 298);
            this.txt_uAddress.Name = "txt_uAddress";
            this.txt_uAddress.Size = new System.Drawing.Size(229, 26);
            this.txt_uAddress.TabIndex = 26;
            this.txt_uAddress.Tag = "Address";
            this.txt_uAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_uFirstName
            // 
            this.txt_uFirstName.Location = new System.Drawing.Point(218, 43);
            this.txt_uFirstName.Name = "txt_uFirstName";
            this.txt_uFirstName.Size = new System.Drawing.Size(229, 26);
            this.txt_uFirstName.TabIndex = 17;
            this.txt_uFirstName.Tag = "First Name";
            this.txt_uFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(37, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 34);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(37, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(37, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 34);
            this.label6.TabIndex = 22;
            this.label6.Text = "Permission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(37, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(37, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "Image Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(37, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(37, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address";
            // 
            // errorProvider1_User
            // 
            this.errorProvider1_User.ContainerControl = this;
            // 
            // upictureBox1
            // 
            this.upictureBox1.Location = new System.Drawing.Point(497, 166);
            this.upictureBox1.Name = "upictureBox1";
            this.upictureBox1.Size = new System.Drawing.Size(196, 184);
            this.upictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upictureBox1.TabIndex = 33;
            this.upictureBox1.TabStop = false;
            // 
            // lblLink_SetImage
            // 
            this.lblLink_SetImage.Location = new System.Drawing.Point(493, 104);
            this.lblLink_SetImage.Name = "lblLink_SetImage";
            this.lblLink_SetImage.Size = new System.Drawing.Size(111, 34);
            this.lblLink_SetImage.TabIndex = 34;
            this.lblLink_SetImage.TabStop = true;
            this.lblLink_SetImage.Text = "Set image ";
            this.lblLink_SetImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLink_Remove
            // 
            this.lblLink_Remove.Location = new System.Drawing.Point(622, 104);
            this.lblLink_Remove.Name = "lblLink_Remove";
            this.lblLink_Remove.Size = new System.Drawing.Size(111, 34);
            this.lblLink_Remove.TabIndex = 35;
            this.lblLink_Remove.TabStop = true;
            this.lblLink_Remove.Text = "Remove";
            this.lblLink_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLink_Remove);
            this.Controls.Add(this.lblLink_SetImage);
            this.Controls.Add(this.upictureBox1);
            this.Controls.Add(this.txt_uImagePath);
            this.Controls.Add(this.txt_uPermission);
            this.Controls.Add(this.txt_uPassword);
            this.Controls.Add(this.txt_uPhone);
            this.Controls.Add(this.txt_uLastName);
            this.Controls.Add(this.txt_uAddress);
            this.Controls.Add(this.txt_uFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(760, 507);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_uImagePath;
        private System.Windows.Forms.TextBox txt_uPermission;
        private System.Windows.Forms.TextBox txt_uPassword;
        private System.Windows.Forms.TextBox txt_uPhone;
        private System.Windows.Forms.TextBox txt_uLastName;
        private System.Windows.Forms.TextBox txt_uAddress;
        private System.Windows.Forms.TextBox txt_uFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox upictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1_User;
        private System.Windows.Forms.LinkLabel lblLink_Remove;
        private System.Windows.Forms.LinkLabel lblLink_SetImage;
    }
}
