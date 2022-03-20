namespace FileTrackingSystem
{
    partial class FisheriesFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FisheriesFileForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCatFil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFilDate = new System.Windows.Forms.DateTimePicker();
            this.labelCatFil = new System.Windows.Forms.Label();
            this.textBoxFilFileName = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtBoxChooseFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colArchive = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileWithExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDel,
            this.colEdit,
            this.colArchive,
            this.colDownload,
            this.FileID,
            this.FileWithExtension,
            this.FileName,
            this.Category,
            this.CreatedAt,
            this.UpdatedAt});
            this.dataGridView1.Location = new System.Drawing.Point(286, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(798, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel1.Controls.Add(this.btnRefresh);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.btnClose);
            this.Panel1.Controls.Add(this.PictureBox5);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1090, 44);
            this.Panel1.TabIndex = 140;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1675, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresh.TabIndex = 84;
            this.btnRefresh.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.Label2.Location = new System.Drawing.Point(516, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 19);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "FISHERIES FILES";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1713, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 34;
            this.btnClose.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(492, 5);
            this.PictureBox5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(33, 34);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 135;
            this.PictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxCatFil);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePickerFilDate);
            this.panel2.Controls.Add(this.labelCatFil);
            this.panel2.Controls.Add(this.textBoxFilFileName);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 611);
            this.panel2.TabIndex = 141;
            // 
            // comboBoxCatFil
            // 
            this.comboBoxCatFil.FormattingEnabled = true;
            this.comboBoxCatFil.Items.AddRange(new object[] {
            "Masterlist of Rice Farmers",
            "Hybrid Users",
            "Certified Seeds User",
            "Fertilizer Users"});
            this.comboBoxCatFil.Location = new System.Drawing.Point(918, 7);
            this.comboBoxCatFil.Name = "comboBoxCatFil";
            this.comboBoxCatFil.Size = new System.Drawing.Size(166, 24);
            this.comboBoxCatFil.TabIndex = 21;
            this.comboBoxCatFil.Visible = false;
            this.comboBoxCatFil.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatFil_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter by filename:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date Created:";
            // 
            // dateTimePickerFilDate
            // 
            this.dateTimePickerFilDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilDate.Location = new System.Drawing.Point(639, 9);
            this.dateTimePickerFilDate.Name = "dateTimePickerFilDate";
            this.dateTimePickerFilDate.Size = new System.Drawing.Size(202, 21);
            this.dateTimePickerFilDate.TabIndex = 19;
            this.dateTimePickerFilDate.ValueChanged += new System.EventHandler(this.dateTimePickerFilDate_ValueChanged);
            // 
            // labelCatFil
            // 
            this.labelCatFil.AutoSize = true;
            this.labelCatFil.Location = new System.Drawing.Point(847, 13);
            this.labelCatFil.Name = "labelCatFil";
            this.labelCatFil.Size = new System.Drawing.Size(65, 16);
            this.labelCatFil.TabIndex = 18;
            this.labelCatFil.Text = "Category :";
            this.labelCatFil.Visible = false;
            // 
            // textBoxFilFileName
            // 
            this.textBoxFilFileName.Location = new System.Drawing.Point(392, 9);
            this.textBoxFilFileName.Name = "textBoxFilFileName";
            this.textBoxFilFileName.Size = new System.Drawing.Size(148, 21);
            this.textBoxFilFileName.TabIndex = 2;
            this.textBoxFilFileName.TextChanged += new System.EventHandler(this.textBoxFilFileName_TextChanged);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(29, 235);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(221, 21);
            this.textBoxFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(147, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 45);
            this.button6.TabIndex = 4;
            this.button6.Text = "Save";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtBoxChooseFile
            // 
            this.txtBoxChooseFile.Enabled = false;
            this.txtBoxChooseFile.Location = new System.Drawing.Point(29, 192);
            this.txtBoxChooseFile.Name = "txtBoxChooseFile";
            this.txtBoxChooseFile.Size = new System.Drawing.Size(186, 21);
            this.txtBoxChooseFile.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose File :";
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.Location = new System.Drawing.Point(214, 192);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(36, 21);
            this.BtnChooseFile.TabIndex = 9;
            this.BtnChooseFile.Text = "...";
            this.BtnChooseFile.UseVisualStyleBackColor = true;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.LblHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 41);
            this.panel3.TabIndex = 11;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.LblHeader.Location = new System.Drawing.Point(5, 11);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(67, 19);
            this.LblHeader.TabIndex = 6;
            this.LblHeader.Text = "Header";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.Location = new System.Drawing.Point(0, 64);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(86, 39);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.Location = new System.Drawing.Point(29, 336);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 45);
            this.button11.TabIndex = 13;
            this.button11.Text = "Update";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "Masterlist of Rice Farmers",
            "Hybrid Users",
            "Certified Seeds User",
            "Fertilizer Users"});
            this.comboBoxCat.Location = new System.Drawing.Point(29, 283);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(186, 24);
            this.comboBoxCat.TabIndex = 14;
            this.comboBoxCat.Visible = false;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(26, 264);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(106, 16);
            this.labelCat.TabIndex = 15;
            this.labelCat.Text = "Choose Category:";
            this.labelCat.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(29, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(221, 45);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.labelCat);
            this.groupBox1.Controls.Add(this.comboBoxCat);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.BtnBack);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.BtnChooseFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxChooseFile);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 592);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "Delete";
            this.colDel.Image = ((System.Drawing.Image)(resources.GetObject("colDel.Image")));
            this.colDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Width = 40;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 40;
            // 
            // colArchive
            // 
            this.colArchive.HeaderText = "Archive";
            this.colArchive.Image = ((System.Drawing.Image)(resources.GetObject("colArchive.Image")));
            this.colArchive.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colArchive.Name = "colArchive";
            this.colArchive.ReadOnly = true;
            this.colArchive.Width = 40;
            // 
            // colDownload
            // 
            this.colDownload.HeaderText = "Download";
            this.colDownload.Image = ((System.Drawing.Image)(resources.GetObject("colDownload.Image")));
            this.colDownload.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDownload.Name = "colDownload";
            this.colDownload.ReadOnly = true;
            this.colDownload.Width = 40;
            // 
            // FileID
            // 
            this.FileID.DataPropertyName = "id";
            this.FileID.HeaderText = "File ID";
            this.FileID.Name = "FileID";
            this.FileID.ReadOnly = true;
            this.FileID.Visible = false;
            // 
            // FileWithExtension
            // 
            this.FileWithExtension.DataPropertyName = "fname_extension";
            this.FileWithExtension.HeaderText = "";
            this.FileWithExtension.Name = "FileWithExtension";
            this.FileWithExtension.ReadOnly = true;
            this.FileWithExtension.Visible = false;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "file_name";
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 250;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "created_at";
            this.CreatedAt.HeaderText = "Created Date";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 120;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "updated_at";
            this.UpdatedAt.HeaderText = "Updated Date";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 120;
            // 
            // FisheriesFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 661);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FisheriesFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FisheriesFileForm";
            this.Load += new System.EventHandler(this.FisheriesFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox btnRefresh;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCatFil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilDate;
        private System.Windows.Forms.Label labelCatFil;
        private System.Windows.Forms.TextBox textBoxFilFileName;
        internal System.Windows.Forms.PictureBox PictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxChooseFile;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.DataGridViewImageColumn colDel;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colArchive;
        private System.Windows.Forms.DataGridViewImageColumn colDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileWithExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}