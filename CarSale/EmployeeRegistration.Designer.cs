namespace CarSale
{
    partial class EmployeeRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegistration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eDevision_cmbo = new System.Windows.Forms.ComboBox();
            this.fmale_rdo = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickeremp = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eEmail_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.male_rdo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eBack_btn = new System.Windows.Forms.Button();
            this.eID_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eSumbit_btn = new System.Windows.Forms.Button();
            this.ldtbl_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.efname_txt = new System.Windows.Forms.TextBox();
            this.esname_txt = new System.Windows.Forms.TextBox();
            this.eAddress_txt = new System.Windows.Forms.TextBox();
            this.ePhone_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarSale.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1087, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // eDevision_cmbo
            // 
            this.eDevision_cmbo.FormattingEnabled = true;
            this.eDevision_cmbo.Items.AddRange(new object[] {
            "Car sale",
            "Service center",
            "Front office",
            "Management",
            "Human resource",
            "Driver",
            "Mechanic",
            "Customer Support"});
            this.eDevision_cmbo.Location = new System.Drawing.Point(243, 292);
            this.eDevision_cmbo.Name = "eDevision_cmbo";
            this.eDevision_cmbo.Size = new System.Drawing.Size(116, 21);
            this.eDevision_cmbo.TabIndex = 30;
            // 
            // fmale_rdo
            // 
            this.fmale_rdo.AutoSize = true;
            this.fmale_rdo.Location = new System.Drawing.Point(304, 190);
            this.fmale_rdo.Name = "fmale_rdo";
            this.fmale_rdo.Size = new System.Drawing.Size(62, 17);
            this.fmale_rdo.TabIndex = 29;
            this.fmale_rdo.TabStop = true;
            this.fmale_rdo.Text = "female";
            this.fmale_rdo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "*Auto generated";
            // 
            // dateTimePickeremp
            // 
            this.dateTimePickeremp.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickeremp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickeremp.Location = new System.Drawing.Point(243, 162);
            this.dateTimePickeremp.Name = "dateTimePickeremp";
            this.dateTimePickeremp.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickeremp.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Image = global::CarSale.Properties.Resources.Search_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(425, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 39);
            this.button3.TabIndex = 37;
            this.button3.Text = "SEARCH";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Image = global::CarSale.Properties.Resources.delete_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(221, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 34;
            this.button2.Text = "DELETE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // eEmail_txt
            // 
            this.eEmail_txt.Location = new System.Drawing.Point(243, 266);
            this.eEmail_txt.Name = "eEmail_txt";
            this.eEmail_txt.Size = new System.Drawing.Size(116, 20);
            this.eEmail_txt.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Image = global::CarSale.Properties.Resources.Very_Basic_Print_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(324, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "PRINT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // male_rdo
            // 
            this.male_rdo.AutoSize = true;
            this.male_rdo.Location = new System.Drawing.Point(243, 190);
            this.male_rdo.Name = "male_rdo";
            this.male_rdo.Size = new System.Drawing.Size(51, 17);
            this.male_rdo.TabIndex = 28;
            this.male_rdo.TabStop = true;
            this.male_rdo.Text = "male";
            this.male_rdo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Controls.Add(this.eBack_btn);
            this.groupBox4.Location = new System.Drawing.Point(917, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 46);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // eBack_btn
            // 
            this.eBack_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.eBack_btn.Image = global::CarSale.Properties.Resources.Arrow_Back_icon;
            this.eBack_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eBack_btn.Location = new System.Drawing.Point(6, 6);
            this.eBack_btn.Name = "eBack_btn";
            this.eBack_btn.Size = new System.Drawing.Size(120, 34);
            this.eBack_btn.TabIndex = 19;
            this.eBack_btn.Text = "BACK TO MAIN";
            this.eBack_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eBack_btn.UseVisualStyleBackColor = false;
            this.eBack_btn.Click += new System.EventHandler(this.eBack_btn_Click_1);
            // 
            // eID_txt
            // 
            this.eID_txt.Location = new System.Drawing.Point(243, 74);
            this.eID_txt.Name = "eID_txt";
            this.eID_txt.Size = new System.Drawing.Size(116, 20);
            this.eID_txt.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(521, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 325);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 296);
            this.dataGridView1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Devision";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.eSumbit_btn);
            this.groupBox2.Controls.Add(this.ldtbl_btn);
            this.groupBox2.Controls.Add(this.update_btn);
            this.groupBox2.Location = new System.Drawing.Point(38, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 64);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // eSumbit_btn
            // 
            this.eSumbit_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.eSumbit_btn.Image = global::CarSale.Properties.Resources.save_icon;
            this.eSumbit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eSumbit_btn.Location = new System.Drawing.Point(15, 19);
            this.eSumbit_btn.Name = "eSumbit_btn";
            this.eSumbit_btn.Size = new System.Drawing.Size(98, 39);
            this.eSumbit_btn.TabIndex = 18;
            this.eSumbit_btn.Text = "SAVE";
            this.eSumbit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eSumbit_btn.UseVisualStyleBackColor = false;
            this.eSumbit_btn.Click += new System.EventHandler(this.eSumbit_btn_Click_1);
            // 
            // ldtbl_btn
            // 
            this.ldtbl_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ldtbl_btn.Image = global::CarSale.Properties.Resources.Household_Table_icon;
            this.ldtbl_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ldtbl_btn.Location = new System.Drawing.Point(521, 19);
            this.ldtbl_btn.Name = "ldtbl_btn";
            this.ldtbl_btn.Size = new System.Drawing.Size(119, 39);
            this.ldtbl_btn.TabIndex = 26;
            this.ldtbl_btn.Text = "LOAD TABLE";
            this.ldtbl_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ldtbl_btn.UseVisualStyleBackColor = false;
            this.ldtbl_btn.Click += new System.EventHandler(this.ldtbl_btn_Click_1);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.update_btn.Image = global::CarSale.Properties.Resources.Very_Basic_Refresh_icon;
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_btn.Location = new System.Drawing.Point(119, 19);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(96, 39);
            this.update_btn.TabIndex = 22;
            this.update_btn.Text = "UPDATE";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insert/Update  Employee data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "EmployeeID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Second Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarSale.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(487, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Date Of Birth";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // efname_txt
            // 
            this.efname_txt.Location = new System.Drawing.Point(243, 99);
            this.efname_txt.Name = "efname_txt";
            this.efname_txt.Size = new System.Drawing.Size(116, 20);
            this.efname_txt.TabIndex = 12;
            // 
            // esname_txt
            // 
            this.esname_txt.Location = new System.Drawing.Point(243, 129);
            this.esname_txt.Name = "esname_txt";
            this.esname_txt.Size = new System.Drawing.Size(116, 20);
            this.esname_txt.TabIndex = 13;
            // 
            // eAddress_txt
            // 
            this.eAddress_txt.Location = new System.Drawing.Point(243, 214);
            this.eAddress_txt.Name = "eAddress_txt";
            this.eAddress_txt.Size = new System.Drawing.Size(116, 20);
            this.eAddress_txt.TabIndex = 14;
            // 
            // ePhone_txt
            // 
            this.ePhone_txt.Location = new System.Drawing.Point(243, 240);
            this.ePhone_txt.Name = "ePhone_txt";
            this.ePhone_txt.Size = new System.Drawing.Size(116, 20);
            this.ePhone_txt.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.eDevision_cmbo);
            this.groupBox1.Controls.Add(this.eEmail_txt);
            this.groupBox1.Controls.Add(this.fmale_rdo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.male_rdo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePickeremp);
            this.groupBox1.Controls.Add(this.eID_txt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.efname_txt);
            this.groupBox1.Controls.Add(this.esname_txt);
            this.groupBox1.Controls.Add(this.eAddress_txt);
            this.groupBox1.Controls.Add(this.ePhone_txt);
            this.groupBox1.Location = new System.Drawing.Point(29, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 334);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Registration";
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeRegistration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox eDevision_cmbo;
        private System.Windows.Forms.RadioButton fmale_rdo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickeremp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox eEmail_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton male_rdo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button eBack_btn;
        private System.Windows.Forms.TextBox eID_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eSumbit_btn;
        private System.Windows.Forms.Button ldtbl_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox efname_txt;
        private System.Windows.Forms.TextBox esname_txt;
        private System.Windows.Forms.TextBox eAddress_txt;
        private System.Windows.Forms.TextBox ePhone_txt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}