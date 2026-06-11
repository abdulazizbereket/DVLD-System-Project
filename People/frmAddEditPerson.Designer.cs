namespace DVDL_System.People
{
    partial class frmAddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPerson));
            this.lblAddUpdateText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.llblRemove = new System.Windows.Forms.LinkLabel();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.ckbCountry = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThird = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddUpdateText
            // 
            this.lblAddUpdateText.AutoSize = true;
            this.lblAddUpdateText.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateText.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddUpdateText.Location = new System.Drawing.Point(295, 27);
            this.lblAddUpdateText.Name = "lblAddUpdateText";
            this.lblAddUpdateText.Size = new System.Drawing.Size(461, 61);
            this.lblAddUpdateText.TabIndex = 0;
            this.lblAddUpdateText.Text = "Add New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(216, 115);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(55, 26);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(162, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 42);
            this.label4.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(435, 578);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(599, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 47);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llblRemove
            // 
            this.llblRemove.AutoSize = true;
            this.llblRemove.LinkColor = System.Drawing.Color.RoyalBlue;
            this.llblRemove.Location = new System.Drawing.Point(802, 469);
            this.llblRemove.Name = "llblRemove";
            this.llblRemove.Size = new System.Drawing.Size(59, 16);
            this.llblRemove.TabIndex = 93;
            this.llblRemove.TabStop = true;
            this.llblRemove.Text = "Remove";
            this.llblRemove.Visible = false;
            this.llblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemove_LinkClicked);
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.LinkColor = System.Drawing.Color.RoyalBlue;
            this.llblSetImage.Location = new System.Drawing.Point(884, 469);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(68, 16);
            this.llblSetImage.TabIndex = 94;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::DVDL_System.Properties.Resources.Male_512;
            this.pbImage.Location = new System.Drawing.Point(796, 246);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 209);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 106;
            this.pbImage.TabStop = false;
            // 
            // label21
            // 
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(267, 300);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 34);
            this.label21.TabIndex = 105;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(306, 304);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(74, 20);
            this.rdFemale.TabIndex = 7;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(199, 304);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(58, 20);
            this.rdMale.TabIndex = 6;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 369);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label20
            // 
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.Location = new System.Drawing.Point(158, 421);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 34);
            this.label20.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(158, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 34);
            this.label18.TabIndex = 103;
            // 
            // label19
            // 
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.Location = new System.Drawing.Point(158, 362);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 34);
            this.label19.TabIndex = 102;
            // 
            // txtAddress
            // 
            this.txtAddress.AllowDrop = true;
            this.txtAddress.Location = new System.Drawing.Point(199, 418);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(558, 150);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.IsEmptyValidation);
            // 
            // ckbCountry
            // 
            this.ckbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ckbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ckbCountry.FormattingEnabled = true;
            this.ckbCountry.Location = new System.Drawing.Point(581, 372);
            this.ckbCountry.Name = "ckbCountry";
            this.ckbCountry.Size = new System.Drawing.Size(176, 24);
            this.ckbCountry.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(536, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 34);
            this.label16.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(440, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 25);
            this.label17.TabIndex = 100;
            this.label17.Text = "Country:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(581, 310);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 22);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(536, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 34);
            this.label14.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(455, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 98;
            this.label15.Text = "Phone:";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(581, 252);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(176, 22);
            this.dtDate.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(536, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 34);
            this.label13.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(396, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 96;
            this.label12.Text = "Date Of Birth:";
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(158, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 34);
            this.label11.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(158, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(854, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 90;
            this.label8.Text = "Last";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(796, 192);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(173, 22);
            this.txtLast.TabIndex = 4;
            this.txtLast.Validating += new System.ComponentModel.CancelEventHandler(this.IsEmptyValidation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(648, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 24);
            this.label9.TabIndex = 88;
            this.label9.Text = "Third";
            // 
            // txtThird
            // 
            this.txtThird.Location = new System.Drawing.Point(590, 192);
            this.txtThird.Name = "txtThird";
            this.txtThird.Size = new System.Drawing.Size(173, 22);
            this.txtThird.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(444, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Second";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(394, 189);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(173, 22);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.Validating += new System.ComponentModel.CancelEventHandler(this.IsEmptyValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(257, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 81;
            this.label6.Text = "First";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Address:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(199, 189);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.IsEmptyValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Gender:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(27, 252);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 25);
            this.label22.TabIndex = 72;
            this.label22.Text = "National NO:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(27, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 25);
            this.label23.TabIndex = 71;
            this.label23.Text = "Name :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(199, 251);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(173, 22);
            this.txtNationalNo.TabIndex = 4;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1057, 643);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.llblRemove);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.ckbCountry);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtThird);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddUpdateText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPerson";
            this.Text = "frmAddEditPerson";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUpdateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llblRemove;
        private System.Windows.Forms.LinkLabel llblSetImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox ckbCountry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThird;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}