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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnView = new System.Windows.Forms.Button();
            this.bttnRegister = new System.Windows.Forms.Button();
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.pnlSurvey.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.textBox1);
            this.pnlMenu.Controls.Add(this.bttnView);
            this.pnlMenu.Controls.Add(this.bttnRegister);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Location = new System.Drawing.Point(30, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1200, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1030, 190);
            this.textBox1.TabIndex = 3;
            // 
            // bttnView
            // 
            this.bttnView.Location = new System.Drawing.Point(70, 480);
            this.bttnView.Name = "bttnView";
            this.bttnView.Size = new System.Drawing.Size(230, 34);
            this.bttnView.TabIndex = 2;
            this.bttnView.Text = "View Contact List";
            this.bttnView.UseVisualStyleBackColor = true;
            // 
            // bttnRegister
            // 
            this.bttnRegister.Location = new System.Drawing.Point(70, 430);
            this.bttnRegister.Name = "bttnRegister";
            this.bttnRegister.Size = new System.Drawing.Size(230, 34);
            this.bttnRegister.TabIndex = 1;
            this.bttnRegister.Text = "Register Contact";
            this.bttnRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
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
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Positive",
            "Negative",
            "Recovered",
            "Monitoring",
            "Deceased"});
            this.cbType.Location = new System.Drawing.Point(250, 420);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(182, 33);
            this.cbType.TabIndex = 10;
            // 
            // cbGender
            // 
            this.cbGender.AllowDrop = true;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Bisexual",
            "Transgender",
            "Queer",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(250, 240);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(730, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Municipality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(570, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Town";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(420, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "House No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "First Name";
            // 
            // txtaMunicipal
            // 
            this.txtaMunicipal.Location = new System.Drawing.Point(730, 340);
            this.txtaMunicipal.Name = "txtaMunicipal";
            this.txtaMunicipal.Size = new System.Drawing.Size(150, 31);
            this.txtaMunicipal.TabIndex = 9;
            // 
            // txtaTown
            // 
            this.txtaTown.Location = new System.Drawing.Point(570, 340);
            this.txtaTown.Name = "txtaTown";
            this.txtaTown.Size = new System.Drawing.Size(150, 31);
            this.txtaTown.TabIndex = 8;
            // 
            // txtaSt
            // 
            this.txtaSt.Location = new System.Drawing.Point(410, 340);
            this.txtaSt.Name = "txtaSt";
            this.txtaSt.Size = new System.Drawing.Size(150, 31);
            this.txtaSt.TabIndex = 7;
            // 
            // txtaNo
            // 
            this.txtaNo.Location = new System.Drawing.Point(250, 340);
            this.txtaNo.Name = "txtaNo";
            this.txtaNo.Size = new System.Drawing.Size(150, 31);
            this.txtaNo.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(250, 290);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(210, 31);
            this.txtContactNo.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(250, 190);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 31);
            this.txtAge.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(470, 120);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(210, 31);
            this.txtlName.TabIndex = 2;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(250, 120);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(210, 31);
            this.txtfName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health Assistant";
            // 
            // pnlQR
            // 
            this.pnlQR.Location = new System.Drawing.Point(30, 30);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(1200, 600);
            this.pnlQR.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dataGridView1);
            this.pnlList.Location = new System.Drawing.Point(20, 20);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1200, 600);
            this.pnlList.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.pnlSurvey);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Health Assistant";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSurvey.ResumeLayout(false);
            this.pnlSurvey.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMenu;
        private TextBox textBox1;
        private Button bttnView;
        private Button bttnRegister;
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
        private DataGridView dataGridView1;
    }
}