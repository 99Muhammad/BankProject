namespace BankProject
{
    partial class frmMainMenue
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToMainMenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMainMenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToManageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ManageClient = new System.Windows.Forms.Button();
            this.btn_ManageUsers = new System.Windows.Forms.Button();
            this.btn_Transaction = new System.Windows.Forms.Button();
            this.btn_Registered = new System.Windows.Forms.Button();
            this.btn_CloseMainMenue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToMainMenueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToMainMenueToolStripMenuItem
            // 
            this.goToMainMenueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientMainMenueToolStripMenuItem,
            this.goToManageUsersToolStripMenuItem,
            this.closeWindowToolStripMenuItem});
            this.goToMainMenueToolStripMenuItem.Image = global::BankProject.Properties.Resources.menu;
            this.goToMainMenueToolStripMenuItem.Name = "goToMainMenueToolStripMenuItem";
            this.goToMainMenueToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.goToMainMenueToolStripMenuItem.Text = "Menus";
            // 
            // clientMainMenueToolStripMenuItem
            // 
            this.clientMainMenueToolStripMenuItem.Image = global::BankProject.Properties.Resources.runer_silhouette_running_fast;
            this.clientMainMenueToolStripMenuItem.Name = "clientMainMenueToolStripMenuItem";
            this.clientMainMenueToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.clientMainMenueToolStripMenuItem.Text = "Go to manage client ";
            this.clientMainMenueToolStripMenuItem.Click += new System.EventHandler(this.clientMainMenueToolStripMenuItem_Click);
            // 
            // goToManageUsersToolStripMenuItem
            // 
            this.goToManageUsersToolStripMenuItem.Image = global::BankProject.Properties.Resources.teamwork;
            this.goToManageUsersToolStripMenuItem.Name = "goToManageUsersToolStripMenuItem";
            this.goToManageUsersToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.goToManageUsersToolStripMenuItem.Text = "Go to manage users";
            this.goToManageUsersToolStripMenuItem.Click += new System.EventHandler(this.goToManageUsersToolStripMenuItem_Click);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Image = global::BankProject.Properties.Resources.two_eyelashes;
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.closeWindowToolStripMenuItem.Text = "Close window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main menue screen ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ManageClient
            // 
            this.btn_ManageClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ManageClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ManageClient.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageClient.Location = new System.Drawing.Point(397, 151);
            this.btn_ManageClient.Name = "btn_ManageClient";
            this.btn_ManageClient.Size = new System.Drawing.Size(377, 55);
            this.btn_ManageClient.TabIndex = 2;
            this.btn_ManageClient.Text = "Go to manage clients";
            this.btn_ManageClient.UseVisualStyleBackColor = true;
            this.btn_ManageClient.Click += new System.EventHandler(this.button1_Click);
            this.btn_ManageClient.MouseLeave += new System.EventHandler(this.btn_ManageClient_MouseLeave);
            this.btn_ManageClient.MouseHover += new System.EventHandler(this.btn_ManageClient_MouseHover);
            // 
            // btn_ManageUsers
            // 
            this.btn_ManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ManageUsers.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageUsers.Location = new System.Drawing.Point(397, 244);
            this.btn_ManageUsers.Name = "btn_ManageUsers";
            this.btn_ManageUsers.Size = new System.Drawing.Size(377, 55);
            this.btn_ManageUsers.TabIndex = 3;
            this.btn_ManageUsers.Text = "Go to manage users";
            this.btn_ManageUsers.UseVisualStyleBackColor = true;
            this.btn_ManageUsers.Click += new System.EventHandler(this.btn_ManageUsers_Click);
            this.btn_ManageUsers.MouseLeave += new System.EventHandler(this.btn_ManageUsers_MouseLeave);
            this.btn_ManageUsers.MouseHover += new System.EventHandler(this.btn_ManageUsers_MouseHover);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Transaction.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transaction.Location = new System.Drawing.Point(397, 328);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(377, 55);
            this.btn_Transaction.TabIndex = 4;
            this.btn_Transaction.Text = "Implement transactions";
            this.btn_Transaction.UseVisualStyleBackColor = true;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            this.btn_Transaction.MouseLeave += new System.EventHandler(this.btn_Transaction_MouseLeave);
            this.btn_Transaction.MouseHover += new System.EventHandler(this.btn_Transaction_MouseHover);
            // 
            // btn_Registered
            // 
            this.btn_Registered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registered.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registered.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registered.Location = new System.Drawing.Point(397, 414);
            this.btn_Registered.Name = "btn_Registered";
            this.btn_Registered.Size = new System.Drawing.Size(377, 55);
            this.btn_Registered.TabIndex = 5;
            this.btn_Registered.Text = "show all registered in the system";
            this.btn_Registered.UseVisualStyleBackColor = true;
            this.btn_Registered.Click += new System.EventHandler(this.btn_Registered_Click);
            this.btn_Registered.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btn_Registered.MouseHover += new System.EventHandler(this.btn_Registered_MouseHover);
            // 
            // btn_CloseMainMenue
            // 
            this.btn_CloseMainMenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseMainMenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CloseMainMenue.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseMainMenue.Location = new System.Drawing.Point(397, 509);
            this.btn_CloseMainMenue.Name = "btn_CloseMainMenue";
            this.btn_CloseMainMenue.Size = new System.Drawing.Size(377, 54);
            this.btn_CloseMainMenue.TabIndex = 6;
            this.btn_CloseMainMenue.Text = "Close screen";
            this.btn_CloseMainMenue.UseVisualStyleBackColor = true;
            this.btn_CloseMainMenue.Click += new System.EventHandler(this.btn_CloseMainMenue_Click);
            // 
            // frmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 677);
            this.Controls.Add(this.btn_CloseMainMenue);
            this.Controls.Add(this.btn_Registered);
            this.Controls.Add(this.btn_Transaction);
            this.Controls.Add(this.btn_ManageUsers);
            this.Controls.Add(this.btn_ManageClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenue";
            this.Text = "Main menue";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToMainMenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMainMenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem goToManageUsersToolStripMenuItem;
        private System.Windows.Forms.Button btn_ManageClient;
        private System.Windows.Forms.Button btn_ManageUsers;
        private System.Windows.Forms.Button btn_Transaction;
        private System.Windows.Forms.Button btn_Registered;
        private System.Windows.Forms.Button btn_CloseMainMenue;
    }
}