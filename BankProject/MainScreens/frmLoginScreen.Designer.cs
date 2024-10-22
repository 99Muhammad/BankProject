namespace BankProject
{
    partial class frmLoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtL_UserName = new System.Windows.Forms.TextBox();
            this.txtL_Password = new System.Windows.Forms.TextBox();
            this.btnL_GoMainScreen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_tryagin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_Password = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(20, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter user name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(20, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter password";
            // 
            // txtL_UserName
            // 
            this.txtL_UserName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL_UserName.Location = new System.Drawing.Point(259, 202);
            this.txtL_UserName.Name = "txtL_UserName";
            this.txtL_UserName.Size = new System.Drawing.Size(251, 37);
            this.txtL_UserName.TabIndex = 2;
            this.txtL_UserName.Tag = "User Name";
            this.txtL_UserName.Validating += new System.ComponentModel.CancelEventHandler(this._Validating);
            // 
            // txtL_Password
            // 
            this.txtL_Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL_Password.Location = new System.Drawing.Point(259, 282);
            this.txtL_Password.Name = "txtL_Password";
            this.txtL_Password.PasswordChar = '*';
            this.txtL_Password.Size = new System.Drawing.Size(251, 37);
            this.txtL_Password.TabIndex = 3;
            this.txtL_Password.Tag = "Password";
            this.txtL_Password.Validating += new System.ComponentModel.CancelEventHandler(this._Validating);
            // 
            // btnL_GoMainScreen
            // 
            this.btnL_GoMainScreen.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL_GoMainScreen.ForeColor = System.Drawing.Color.Purple;
            this.btnL_GoMainScreen.Location = new System.Drawing.Point(122, 517);
            this.btnL_GoMainScreen.Name = "btnL_GoMainScreen";
            this.btnL_GoMainScreen.Size = new System.Drawing.Size(312, 59);
            this.btnL_GoMainScreen.TabIndex = 4;
            this.btnL_GoMainScreen.Text = "Go to main screen";
            this.btnL_GoMainScreen.UseVisualStyleBackColor = true;
            this.btnL_GoMainScreen.Click += new System.EventHandler(this.btnL_GoMainScreen_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Timer.Location = new System.Drawing.Point(282, 408);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(123, 38);
            this.lbl_Timer.TabIndex = 5;
            this.lbl_Timer.Text = "0";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbl_tryagin
            // 
            this.lbl_tryagin.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tryagin.ForeColor = System.Drawing.Color.Red;
            this.lbl_tryagin.Location = new System.Drawing.Point(20, 408);
            this.lbl_tryagin.Name = "lbl_tryagin";
            this.lbl_tryagin.Size = new System.Drawing.Size(247, 38);
            this.lbl_tryagin.TabIndex = 6;
            this.lbl_tryagin.Text = "Wait ...";
            this.lbl_tryagin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(144, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_Password
            // 
            this.chk_Password.AutoSize = true;
            this.chk_Password.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Password.ForeColor = System.Drawing.Color.Purple;
            this.chk_Password.Location = new System.Drawing.Point(26, 313);
            this.chk_Password.Name = "chk_Password";
            this.chk_Password.Size = new System.Drawing.Size(185, 29);
            this.chk_Password.TabIndex = 8;
            this.chk_Password.Text = "Show password";
            this.chk_Password.UseVisualStyleBackColor = true;
            this.chk_Password.CheckedChanged += new System.EventHandler(this.chk_Password_CheckedChanged);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(577, 631);
            this.Controls.Add(this.chk_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tryagin);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.btnL_GoMainScreen);
            this.Controls.Add(this.txtL_Password);
            this.Controls.Add(this.txtL_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLoginScreen";
            this.Text = "Login screen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtL_UserName;
        private System.Windows.Forms.TextBox txtL_Password;
        private System.Windows.Forms.Button btnL_GoMainScreen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl_tryagin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_Password;
    }
}