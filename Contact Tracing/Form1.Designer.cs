namespace Contact_Tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnToList = new System.Windows.Forms.Button();
            this.bttnToSurvey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSurvey = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnQR = new System.Windows.Forms.Button();
            this.bttnBackSurvey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtaMunicipal = new System.Windows.Forms.TextBox();
            this.txtaTown = new System.Windows.Forms.TextBox();
            this.txtaSt = new System.Windows.Forms.TextBox();
            this.txtaNo = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlQR = new System.Windows.Forms.Panel();
            this.bttnSaveQR = new System.Windows.Forms.Button();
            this.bttnBackQR = new System.Windows.Forms.Button();
            this.txtQRResult = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bttnScan = new System.Windows.Forms.Button();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.bttnBackList = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.timerQR = new System.Windows.Forms.Timer(this.components);
            label16 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlSurvey.SuspendLayout();
            this.pnlQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(60, 100);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(64, 25);
            label16.TabIndex = 37;
            label16.Text = "Search";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenu.Controls.Add(this.textBox1);
            this.pnlMenu.Controls.Add(this.bttnToList);
            this.pnlMenu.Controls.Add(this.bttnToSurvey);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(30, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1200, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 400);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // bttnToList
            // 
            this.bttnToList.Location = new System.Drawing.Point(160, 310);
            this.bttnToList.Name = "bttnToList";
            this.bttnToList.Size = new System.Drawing.Size(230, 34);
            this.bttnToList.TabIndex = 2;
            this.bttnToList.Text = "View Contact List";
            this.bttnToList.UseVisualStyleBackColor = true;
            this.bttnToList.Click += new System.EventHandler(this.bttnToList_Click);
            // 
            // bttnToSurvey
            // 
            this.bttnToSurvey.Location = new System.Drawing.Point(160, 250);
            this.bttnToSurvey.Name = "bttnToSurvey";
            this.bttnToSurvey.Size = new System.Drawing.Size(230, 34);
            this.bttnToSurvey.TabIndex = 1;
            this.bttnToSurvey.Text = "Create New Contact";
            this.bttnToSurvey.UseVisualStyleBackColor = true;
            this.bttnToSurvey.Click += new System.EventHandler(this.bttnToSurvey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Assistant";
            // 
            // pnlSurvey
            // 
            this.pnlSurvey.AllowDrop = true;
            this.pnlSurvey.Controls.Add(this.cbType);
            this.pnlSurvey.Controls.Add(this.cbGender);
            this.pnlSurvey.Controls.Add(this.bttnSave);
            this.pnlSurvey.Controls.Add(this.bttnQR);
            this.pnlSurvey.Controls.Add(this.bttnBackSurvey);
            this.pnlSurvey.Controls.Add(this.label5);
            this.pnlSurvey.Controls.Add(this.label15);
            this.pnlSurvey.Controls.Add(this.label14);
            this.pnlSurvey.Controls.Add(this.label13);
            this.pnlSurvey.Controls.Add(this.label12);
            this.pnlSurvey.Controls.Add(this.label11);
            this.pnlSurvey.Controls.Add(this.label10);
            this.pnlSurvey.Controls.Add(this.txtaMunicipal);
            this.pnlSurvey.Controls.Add(this.txtaTown);
            this.pnlSurvey.Controls.Add(this.txtaSt);
            this.pnlSurvey.Controls.Add(this.txtaNo);
            this.pnlSurvey.Controls.Add(this.txtContactNo);
            this.pnlSurvey.Controls.Add(this.txtAge);
            this.pnlSurvey.Controls.Add(this.label9);
            this.pnlSurvey.Controls.Add(this.txtlName);
            this.pnlSurvey.Controls.Add(this.txtfName);
            this.pnlSurvey.Controls.Add(this.label7);
            this.pnlSurvey.Controls.Add(this.label6);
            this.pnlSurvey.Controls.Add(this.label4);
            this.pnlSurvey.Controls.Add(this.label3);
            this.pnlSurvey.Controls.Add(this.label2);
            this.pnlSurvey.Location = new System.Drawing.Point(20, 10);
            this.pnlSurvey.Name = "pnlSurvey";
            this.pnlSurvey.Size = new System.Drawing.Size(1200, 600);
            this.pnlSurvey.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Positive",
            "Negative",
            "Recovered",
            "Monitoring",
            "Deceased"});
            this.cbType.Location = new System.Drawing.Point(290, 410);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(182, 33);
            this.cbType.TabIndex = 10;
            // 
            // cbGender
            // 
            this.cbGender.AllowDrop = true;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Bisexual",
            "Transgender",
            "Queer",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(290, 230);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(182, 33);
            this.cbGender.TabIndex = 4;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(1050, 550);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(112, 34);
            this.bttnSave.TabIndex = 13;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnQR
            // 
            this.bttnQR.Location = new System.Drawing.Point(550, 540);
            this.bttnQR.Name = "bttnQR";
            this.bttnQR.Size = new System.Drawing.Size(112, 34);
            this.bttnQR.TabIndex = 12;
            this.bttnQR.Text = "Scan QR";
            this.bttnQR.UseVisualStyleBackColor = true;
            // 
            // bttnBackSurvey
            // 
            this.bttnBackSurvey.Location = new System.Drawing.Point(40, 550);
            this.bttnBackSurvey.Name = "bttnBackSurvey";
            this.bttnBackSurvey.Size = new System.Drawing.Size(112, 34);
            this.bttnBackSurvey.TabIndex = 11;
            this.bttnBackSurvey.Text = "Back";
            this.bttnBackSurvey.UseVisualStyleBackColor = true;
            this.bttnBackSurvey.Click += new System.EventHandler(this.bttnBackSurvey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(770, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Municipality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(610, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Town";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(460, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "House No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "First Name";
            // 
            // txtaMunicipal
            // 
            this.txtaMunicipal.Location = new System.Drawing.Point(770, 330);
            this.txtaMunicipal.Name = "txtaMunicipal";
            this.txtaMunicipal.Size = new System.Drawing.Size(150, 31);
            this.txtaMunicipal.TabIndex = 9;
            // 
            // txtaTown
            // 
            this.txtaTown.Location = new System.Drawing.Point(610, 330);
            this.txtaTown.Name = "txtaTown";
            this.txtaTown.Size = new System.Drawing.Size(150, 31);
            this.txtaTown.TabIndex = 8;
            // 
            // txtaSt
            // 
            this.txtaSt.Location = new System.Drawing.Point(450, 330);
            this.txtaSt.Name = "txtaSt";
            this.txtaSt.Size = new System.Drawing.Size(150, 31);
            this.txtaSt.TabIndex = 7;
            // 
            // txtaNo
            // 
            this.txtaNo.Location = new System.Drawing.Point(290, 330);
            this.txtaNo.Name = "txtaNo";
            this.txtaNo.Size = new System.Drawing.Size(150, 31);
            this.txtaNo.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(290, 280);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(210, 31);
            this.txtContactNo.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(290, 180);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 31);
            this.txtAge.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(510, 110);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(210, 31);
            this.txtlName.TabIndex = 2;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(290, 110);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(210, 31);
            this.txtfName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health Assistant";
            // 
            // pnlQR
            // 
            this.pnlQR.Controls.Add(this.bttnSaveQR);
            this.pnlQR.Controls.Add(this.bttnBackQR);
            this.pnlQR.Controls.Add(this.txtQRResult);
            this.pnlQR.Controls.Add(this.label18);
            this.pnlQR.Controls.Add(this.bttnScan);
            this.pnlQR.Controls.Add(this.cbDevice);
            this.pnlQR.Controls.Add(this.pbQR);
            this.pnlQR.Controls.Add(this.label17);
            this.pnlQR.Location = new System.Drawing.Point(30, 30);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(1200, 600);
            this.pnlQR.TabIndex = 0;
            // 
            // bttnSaveQR
            // 
            this.bttnSaveQR.Location = new System.Drawing.Point(1040, 530);
            this.bttnSaveQR.Name = "bttnSaveQR";
            this.bttnSaveQR.Size = new System.Drawing.Size(112, 34);
            this.bttnSaveQR.TabIndex = 7;
            this.bttnSaveQR.Text = "Save";
            this.bttnSaveQR.UseVisualStyleBackColor = true;
            // 
            // bttnBackQR
            // 
            this.bttnBackQR.Location = new System.Drawing.Point(60, 520);
            this.bttnBackQR.Name = "bttnBackQR";
            this.bttnBackQR.Size = new System.Drawing.Size(112, 34);
            this.bttnBackQR.TabIndex = 6;
            this.bttnBackQR.Text = "Back";
            this.bttnBackQR.UseVisualStyleBackColor = true;
            // 
            // txtQRResult
            // 
            this.txtQRResult.Location = new System.Drawing.Point(160, 190);
            this.txtQRResult.Multiline = true;
            this.txtQRResult.Name = "txtQRResult";
            this.txtQRResult.Size = new System.Drawing.Size(360, 220);
            this.txtQRResult.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(150, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 25);
            this.label18.TabIndex = 4;
            this.label18.Text = "Device:";
            // 
            // bttnScan
            // 
            this.bttnScan.Location = new System.Drawing.Point(290, 440);
            this.bttnScan.Name = "bttnScan";
            this.bttnScan.Size = new System.Drawing.Size(112, 34);
            this.bttnScan.TabIndex = 3;
            this.bttnScan.Text = "Scan QR";
            this.bttnScan.UseVisualStyleBackColor = true;
            this.bttnScan.Click += new System.EventHandler(this.bttnScan_Click);
            // 
            // cbDevice
            // 
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(250, 120);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(210, 33);
            this.cbDevice.TabIndex = 2;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(650, 90);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(400, 400);
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(20, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(292, 45);
            this.label17.TabIndex = 0;
            this.label17.Text = "Health Assitant";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.bttnBackList);
            this.pnlList.Controls.Add(label16);
            this.pnlList.Controls.Add(this.txtSearch);
            this.pnlList.Controls.Add(this.label8);
            this.pnlList.Controls.Add(this.dgvContactList);
            this.pnlList.Location = new System.Drawing.Point(20, 20);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1200, 600);
            this.pnlList.TabIndex = 35;
            // 
            // bttnBackList
            // 
            this.bttnBackList.Location = new System.Drawing.Point(60, 550);
            this.bttnBackList.Name = "bttnBackList";
            this.bttnBackList.Size = new System.Drawing.Size(112, 34);
            this.bttnBackList.TabIndex = 38;
            this.bttnBackList.Text = "Back";
            this.bttnBackList.UseVisualStyleBackColor = true;
            this.bttnBackList.Click += new System.EventHandler(this.bttnBackList_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 31);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(40, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 45);
            this.label8.TabIndex = 2;
            this.label8.Text = "Health Assistant";
            // 
            // dgvContactList
            // 
            this.dgvContactList.AllowUserToAddRows = false;
            this.dgvContactList.AllowUserToDeleteRows = false;
            this.dgvContactList.AllowUserToOrderColumns = true;
            this.dgvContactList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvContactList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvContactList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(60, 150);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersWidth = 62;
            this.dgvContactList.RowTemplate.Height = 33;
            this.dgvContactList.Size = new System.Drawing.Size(1100, 350);
            this.dgvContactList.TabIndex = 0;
            // 
            // timerQR
            // 
            this.timerQR.Interval = 1000;
            this.timerQR.Tick += new System.EventHandler(this.timerQR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.pnlQR);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlSurvey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Health Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSurvey.ResumeLayout(false);
            this.pnlSurvey.PerformLayout();
            this.pnlQR.ResumeLayout(false);
            this.pnlQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMenu;
        private Button bttnToList;
        private Button bttnToSurvey;
        private Label label1;
        private Panel pnlSurvey;
        private TextBox txtAge;
        private Label label9;
        private TextBox txtlName;
        private TextBox txtfName;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlQR;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtaMunicipal;
        private TextBox txtaTown;
        private TextBox txtaSt;
        private TextBox txtaNo;
        private TextBox txtContactNo;
        private Label label5;
        private Button bttnSave;
        private Button bttnQR;
        private Button bttnBackSurvey;
        private Panel pnlList;
        private ComboBox cbType;
        private ComboBox cbGender;
        private DataGridView dgvContactList;
        private Label label8;
        private Button bttnBackList;
        private TextBox txtSearch;
        private TextBox textBox1;
        private Button bttnBackQR;
        private TextBox txtQRResult;
        private Label label18;
        private Button bttnScan;
        private ComboBox cbDevice;
        private PictureBox pbQR;
        private Label label17;
        private Button bttnSaveQR;
        private System.Windows.Forms.Timer timerQR;
    }
}