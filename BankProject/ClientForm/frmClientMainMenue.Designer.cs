namespace BankProject
{
    partial class frm_ClientMenue
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
            this.tt_All = new System.Windows.Forms.TabControl();
            this.tp_AddClient = new System.Windows.Forms.TabPage();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_ImagePath = new System.Windows.Forms.TextBox();
            this.txt_PinCode = new System.Windows.Forms.TextBox();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.txt_AccountNumber = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_UpdateScreen = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ShowPreData = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tp_DeleteScreen = new System.Windows.Forms.TabPage();
            this.btnShowInfoClient = new System.Windows.Forms.Button();
            this.txtBoxDel = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tp_ListScreen = new System.Windows.Forms.TabPage();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderingNameASCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderingByNameDESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_FindScreen = new System.Windows.Forms.TabPage();
            this.btn_CloseFind = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtAccount1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_All.SuspendLayout();
            this.tp_AddClient.SuspendLayout();
            this.tp_UpdateScreen.SuspendLayout();
            this.tp_DeleteScreen.SuspendLayout();
            this.tp_ListScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tp_FindScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_All
            // 
            this.tt_All.Controls.Add(this.tp_AddClient);
            this.tt_All.Controls.Add(this.tp_UpdateScreen);
            this.tt_All.Controls.Add(this.tp_DeleteScreen);
            this.tt_All.Controls.Add(this.tp_ListScreen);
            this.tt_All.Controls.Add(this.tp_FindScreen);
            this.tt_All.Location = new System.Drawing.Point(12, -6);
            this.tt_All.Name = "tt_All";
            this.tt_All.SelectedIndex = 0;
            this.tt_All.Size = new System.Drawing.Size(1460, 725);
            this.tt_All.TabIndex = 0;
            this.tt_All.SelectedIndexChanged += new System.EventHandler(this.tt_Update_SelectedIndexChanged);
            // 
            // tp_AddClient
            // 
            this.tp_AddClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tp_AddClient.Controls.Add(this.btn_Close);
            this.tp_AddClient.Controls.Add(this.btn_Save);
            this.tp_AddClient.Controls.Add(this.txt_ImagePath);
            this.tp_AddClient.Controls.Add(this.txt_PinCode);
            this.tp_AddClient.Controls.Add(this.txt_Balance);
            this.tp_AddClient.Controls.Add(this.txt_AccountNumber);
            this.tp_AddClient.Controls.Add(this.txt_Phone);
            this.tp_AddClient.Controls.Add(this.txt_LastName);
            this.tp_AddClient.Controls.Add(this.txt_Address);
            this.tp_AddClient.Controls.Add(this.txt_FirstName);
            this.tp_AddClient.Controls.Add(this.label9);
            this.tp_AddClient.Controls.Add(this.label8);
            this.tp_AddClient.Controls.Add(this.label7);
            this.tp_AddClient.Controls.Add(this.label6);
            this.tp_AddClient.Controls.Add(this.label5);
            this.tp_AddClient.Controls.Add(this.label4);
            this.tp_AddClient.Controls.Add(this.label3);
            this.tp_AddClient.Controls.Add(this.label2);
            this.tp_AddClient.Controls.Add(this.label1);
            this.tp_AddClient.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_AddClient.Location = new System.Drawing.Point(4, 29);
            this.tp_AddClient.Name = "tp_AddClient";
            this.tp_AddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tp_AddClient.Size = new System.Drawing.Size(1452, 692);
            this.tp_AddClient.TabIndex = 0;
            this.tp_AddClient.Text = "Add New Client";
            this.tp_AddClient.Click += new System.EventHandler(this.tp_AddClient_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close.Location = new System.Drawing.Point(361, 609);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(152, 61);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(630, 609);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(152, 61);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(790, 498);
            this.txt_ImagePath.MaxLength = 200;
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Size = new System.Drawing.Size(229, 42);
            this.txt_ImagePath.TabIndex = 7;
            this.txt_ImagePath.Tag = "";
            // 
            // txt_PinCode
            // 
            this.txt_PinCode.Location = new System.Drawing.Point(790, 390);
            this.txt_PinCode.MaxLength = 5;
            this.txt_PinCode.Name = "txt_PinCode";
            this.txt_PinCode.Size = new System.Drawing.Size(229, 42);
            this.txt_PinCode.TabIndex = 6;
            this.txt_PinCode.Tag = "Pin Code";
            this.txt_PinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(790, 273);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(229, 42);
            this.txt_Balance.TabIndex = 5;
            this.txt_Balance.Tag = "Balance";
            this.txt_Balance.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_AccountNumber
            // 
            this.txt_AccountNumber.Location = new System.Drawing.Point(327, 494);
            this.txt_AccountNumber.MaxLength = 10;
            this.txt_AccountNumber.Name = "txt_AccountNumber";
            this.txt_AccountNumber.Size = new System.Drawing.Size(229, 42);
            this.txt_AccountNumber.TabIndex = 3;
            this.txt_AccountNumber.Tag = "Acount Number";
            this.txt_AccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(327, 393);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(229, 42);
            this.txt_Phone.TabIndex = 2;
            this.txt_Phone.Tag = "Phone";
            this.txt_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(327, 269);
            this.txt_LastName.MaxLength = 35;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(229, 42);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.Tag = "Last Name";
            this.txt_LastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(790, 174);
            this.txt_Address.MaxLength = 40;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(229, 42);
            this.txt_Address.TabIndex = 4;
            this.txt_Address.Tag = "Address";
            this.txt_Address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(327, 174);
            this.txt_FirstName.MaxLength = 35;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(229, 42);
            this.txt_FirstName.TabIndex = 0;
            this.txt_FirstName.Tag = "First Name";
            this.txt_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(624, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 34);
            this.label9.TabIndex = 8;
            this.label9.Text = "PinCode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(97, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(97, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(624, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(98, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(624, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(97, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(624, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(350, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new client screen";
            // 
            // tp_UpdateScreen
            // 
            this.tp_UpdateScreen.BackColor = System.Drawing.Color.White;
            this.tp_UpdateScreen.Controls.Add(this.button1);
            this.tp_UpdateScreen.Controls.Add(this.btn_ShowPreData);
            this.tp_UpdateScreen.Controls.Add(this.btn_Update);
            this.tp_UpdateScreen.Controls.Add(this.txtAddress);
            this.tp_UpdateScreen.Controls.Add(this.txtImagePath);
            this.tp_UpdateScreen.Controls.Add(this.txtFirstName);
            this.tp_UpdateScreen.Controls.Add(this.txtLastName);
            this.tp_UpdateScreen.Controls.Add(this.txtPinCode);
            this.tp_UpdateScreen.Controls.Add(this.txtPhone);
            this.tp_UpdateScreen.Controls.Add(this.txtBalance);
            this.tp_UpdateScreen.Controls.Add(this.label19);
            this.tp_UpdateScreen.Controls.Add(this.label18);
            this.tp_UpdateScreen.Controls.Add(this.label17);
            this.tp_UpdateScreen.Controls.Add(this.label16);
            this.tp_UpdateScreen.Controls.Add(this.label15);
            this.tp_UpdateScreen.Controls.Add(this.label14);
            this.tp_UpdateScreen.Controls.Add(this.label13);
            this.tp_UpdateScreen.Controls.Add(this.txtAccountNumber);
            this.tp_UpdateScreen.Controls.Add(this.label11);
            this.tp_UpdateScreen.Controls.Add(this.label10);
            this.tp_UpdateScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tp_UpdateScreen.Location = new System.Drawing.Point(4, 29);
            this.tp_UpdateScreen.Name = "tp_UpdateScreen";
            this.tp_UpdateScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_UpdateScreen.Size = new System.Drawing.Size(1452, 692);
            this.tp_UpdateScreen.TabIndex = 1;
            this.tp_UpdateScreen.Text = "Update Client Info";
            this.tp_UpdateScreen.Click += new System.EventHandler(this.tp_UpdateScreen_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(461, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 65);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ShowPreData
            // 
            this.btn_ShowPreData.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowPreData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPreData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShowPreData.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowPreData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ShowPreData.Location = new System.Drawing.Point(853, 133);
            this.btn_ShowPreData.Name = "btn_ShowPreData";
            this.btn_ShowPreData.Size = new System.Drawing.Size(302, 46);
            this.btn_ShowPreData.TabIndex = 1;
            this.btn_ShowPreData.Text = "Show previous data";
            this.btn_ShowPreData.UseVisualStyleBackColor = false;
            this.btn_ShowPreData.Click += new System.EventHandler(this.btnLoadPreviousInfo_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(735, 596);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(189, 65);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(797, 279);
            this.txtAddress.MaxLength = 40;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 37);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Tag = "Address";
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.Location = new System.Drawing.Point(797, 434);
            this.txtImagePath.MaxLength = 400;
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(444, 37);
            this.txtImagePath.TabIndex = 8;
            this.txtImagePath.Tag = "Image path";
            this.txtImagePath.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(178, 281);
            this.txtFirstName.MaxLength = 35;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(193, 37);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Tag = "FirstName";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(178, 366);
            this.txtLastName.MaxLength = 35;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 37);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Tag = "LastName";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(178, 434);
            this.txtPinCode.MaxLength = 4;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(193, 37);
            this.txtPinCode.TabIndex = 4;
            this.txtPinCode.Tag = "PinCode";
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(178, 522);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(193, 37);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Tag = "Phone";
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(797, 366);
            this.txtBalance.MaxLength = 200;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(229, 37);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.Tag = "Balance";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(20, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(234, 35);
            this.label19.TabIndex = 10;
            this.label19.Text = "First Name";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(20, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 35);
            this.label18.TabIndex = 9;
            this.label18.Text = "Last name";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(20, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(234, 35);
            this.label17.TabIndex = 8;
            this.label17.Text = "Pin Code";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(20, 513);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(234, 35);
            this.label16.TabIndex = 7;
            this.label16.Text = "Phone";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(586, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 35);
            this.label15.TabIndex = 6;
            this.label15.Text = "Balance";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(586, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 35);
            this.label14.TabIndex = 5;
            this.label14.Text = "Address";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(586, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 35);
            this.label13.TabIndex = 4;
            this.label13.Text = "Image path";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(627, 151);
            this.txtAccountNumber.MaxLength = 10;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(193, 37);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.Tag = "Acount Number";
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating_);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(274, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "Enter Account number";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(311, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(676, 70);
            this.label10.TabIndex = 0;
            this.label10.Text = "Customer information update screen";
            // 
            // tp_DeleteScreen
            // 
            this.tp_DeleteScreen.Controls.Add(this.btnShowInfoClient);
            this.tp_DeleteScreen.Controls.Add(this.txtBoxDel);
            this.tp_DeleteScreen.Controls.Add(this.label20);
            this.tp_DeleteScreen.Controls.Add(this.label12);
            this.tp_DeleteScreen.Location = new System.Drawing.Point(4, 29);
            this.tp_DeleteScreen.Name = "tp_DeleteScreen";
            this.tp_DeleteScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DeleteScreen.Size = new System.Drawing.Size(1452, 692);
            this.tp_DeleteScreen.TabIndex = 2;
            this.tp_DeleteScreen.Text = "Delete Client ";
            this.tp_DeleteScreen.UseVisualStyleBackColor = true;
            this.tp_DeleteScreen.Click += new System.EventHandler(this.tp_DeleteScreen_Click);
            // 
            // btnShowInfoClient
            // 
            this.btnShowInfoClient.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfoClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowInfoClient.Location = new System.Drawing.Point(425, 339);
            this.btnShowInfoClient.Name = "btnShowInfoClient";
            this.btnShowInfoClient.Size = new System.Drawing.Size(634, 50);
            this.btnShowInfoClient.TabIndex = 1;
            this.btnShowInfoClient.Text = "Show client information you want to delete";
            this.btnShowInfoClient.UseVisualStyleBackColor = true;
            this.btnShowInfoClient.Click += new System.EventHandler(this.btn_ShowClientInfo);
            // 
            // txtBoxDel
            // 
            this.txtBoxDel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDel.Location = new System.Drawing.Point(760, 213);
            this.txtBoxDel.MaxLength = 10;
            this.txtBoxDel.Name = "txtBoxDel";
            this.txtBoxDel.Size = new System.Drawing.Size(343, 33);
            this.txtBoxDel.TabIndex = 0;
            this.txtBoxDel.Tag = "Account number";
            this.txtBoxDel.TextChanged += new System.EventHandler(this.txtBoxDel_TextChanged);
            this.txtBoxDel.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxDel_Validating);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(317, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(452, 57);
            this.label20.TabIndex = 1;
            this.label20.Text = "Enter account number";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Elephant", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(365, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(543, 67);
            this.label12.TabIndex = 0;
            this.label12.Text = "Delete client screen";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tp_ListScreen
            // 
            this.tp_ListScreen.Controls.Add(this.txtSearchByName);
            this.tp_ListScreen.Controls.Add(this.label24);
            this.tp_ListScreen.Controls.Add(this.label23);
            this.tp_ListScreen.Controls.Add(this.dataGridView1);
            this.tp_ListScreen.Location = new System.Drawing.Point(4, 29);
            this.tp_ListScreen.Name = "tp_ListScreen";
            this.tp_ListScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ListScreen.Size = new System.Drawing.Size(1452, 692);
            this.tp_ListScreen.TabIndex = 3;
            this.tp_ListScreen.Text = "List Client";
            this.tp_ListScreen.UseVisualStyleBackColor = true;
            this.tp_ListScreen.Click += new System.EventHandler(this.tp_ListScreen_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(616, 121);
            this.txtSearchByName.MaxLength = 35;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(380, 37);
            this.txtSearchByName.TabIndex = 0;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txt_SearchByName);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Teal;
            this.label24.Location = new System.Drawing.Point(232, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(354, 48);
            this.label24.TabIndex = 2;
            this.label24.Text = "Enter client name";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Engravers MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(409, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(507, 82);
            this.label23.TabIndex = 1;
            this.label23.Text = "List client screen";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1421, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderingNameASCToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderingNameASCToolStripMenuItem,
            this.orderingByNameDESCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(294, 68);
            // 
            // orderingNameASCToolStripMenuItem
            // 
            this.orderingNameASCToolStripMenuItem.Name = "orderingNameASCToolStripMenuItem";
            this.orderingNameASCToolStripMenuItem.Size = new System.Drawing.Size(293, 32);
            this.orderingNameASCToolStripMenuItem.Text = "Ordering by name ASC";
            this.orderingNameASCToolStripMenuItem.Click += new System.EventHandler(this.orderingNameASCToolStripMenuItem_Click);
            // 
            // orderingByNameDESCToolStripMenuItem
            // 
            this.orderingByNameDESCToolStripMenuItem.Name = "orderingByNameDESCToolStripMenuItem";
            this.orderingByNameDESCToolStripMenuItem.Size = new System.Drawing.Size(293, 32);
            this.orderingByNameDESCToolStripMenuItem.Text = "Ordering by balance DESC";
            this.orderingByNameDESCToolStripMenuItem.Click += new System.EventHandler(this.orderingByNameDESCToolStripMenuItem_Click);
            // 
            // tp_FindScreen
            // 
            this.tp_FindScreen.Controls.Add(this.btn_CloseFind);
            this.tp_FindScreen.Controls.Add(this.btn_Search);
            this.tp_FindScreen.Controls.Add(this.dataGridView2);
            this.tp_FindScreen.Controls.Add(this.txtAccount1);
            this.tp_FindScreen.Controls.Add(this.label26);
            this.tp_FindScreen.Controls.Add(this.label25);
            this.tp_FindScreen.Location = new System.Drawing.Point(4, 29);
            this.tp_FindScreen.Name = "tp_FindScreen";
            this.tp_FindScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_FindScreen.Size = new System.Drawing.Size(1452, 692);
            this.tp_FindScreen.TabIndex = 4;
            this.tp_FindScreen.Text = "Find Client";
            this.tp_FindScreen.UseVisualStyleBackColor = true;
            // 
            // btn_CloseFind
            // 
            this.btn_CloseFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseFind.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CloseFind.Location = new System.Drawing.Point(538, 487);
            this.btn_CloseFind.Name = "btn_CloseFind";
            this.btn_CloseFind.Size = new System.Drawing.Size(201, 41);
            this.btn_CloseFind.TabIndex = 5;
            this.btn_CloseFind.Text = "Close";
            this.btn_CloseFind.UseVisualStyleBackColor = true;
            this.btn_CloseFind.Click += new System.EventHandler(this.btn_CloseFind_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(778, 118);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(201, 41);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(57, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1286, 172);
            this.dataGridView2.TabIndex = 3;
            // 
            // txtAccount1
            // 
            this.txtAccount1.Location = new System.Drawing.Point(408, 133);
            this.txtAccount1.Name = "txtAccount1";
            this.txtAccount1.Size = new System.Drawing.Size(314, 26);
            this.txtAccount1.TabIndex = 2;
            this.txtAccount1.TextChanged += new System.EventHandler(this.txtAccount1_TextChanged);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(69, 118);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(333, 42);
            this.label26.TabIndex = 1;
            this.label26.Text = "Enter account number";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(326, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(653, 63);
            this.label25.TabIndex = 0;
            this.label25.Text = "Find client  screen ";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_ClientMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.Controls.Add(this.tt_All);
            this.Name = "frm_ClientMenue";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Client Menu";
            this.Load += new System.EventHandler(this.frm_MainMenue_Load);
            this.tt_All.ResumeLayout(false);
            this.tp_AddClient.ResumeLayout(false);
            this.tp_AddClient.PerformLayout();
            this.tp_UpdateScreen.ResumeLayout(false);
            this.tp_UpdateScreen.PerformLayout();
            this.tp_DeleteScreen.ResumeLayout(false);
            this.tp_DeleteScreen.PerformLayout();
            this.tp_ListScreen.ResumeLayout(false);
            this.tp_ListScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tp_FindScreen.ResumeLayout(false);
            this.tp_FindScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tt_All;
        private System.Windows.Forms.TabPage tp_AddClient;
        private System.Windows.Forms.TabPage tp_UpdateScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ImagePath;
        private System.Windows.Forms.TextBox txt_PinCode;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.TextBox txt_AccountNumber;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_ShowPreData;
        private System.Windows.Forms.TabPage tp_DeleteScreen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnShowInfoClient;
        private System.Windows.Forms.TextBox txtBoxDel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tp_ListScreen;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tp_FindScreen;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtAccount1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderingNameASCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderingByNameDESCToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CloseFind;
    }
}

