namespace FileTrackingSystem
{
    partial class GenerateCalamityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateCalamityForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsbsa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.comboBoxTypesOfCalamity = new System.Windows.Forms.ComboBox();
            this.comboBoxBudgetF = new System.Windows.Forms.ComboBox();
            this.labelTypesOfCalamity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOccupation = new System.Windows.Forms.ComboBox();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.FullName,
            this.Occupation,
            this.Address,
            this.rsbsa_id});
            this.dataGridView1.Location = new System.Drawing.Point(15, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Selection
            // 
            this.Selection.HeaderText = "Selection";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.Width = 60;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // Occupation
            // 
            this.Occupation.DataPropertyName = "livelihood";
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.Name = "Occupation";
            this.Occupation.ReadOnly = true;
            this.Occupation.Width = 200;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "brgy";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // rsbsa_id
            // 
            this.rsbsa_id.HeaderText = "ID";
            this.rsbsa_id.Name = "rsbsa_id";
            this.rsbsa_id.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Panel1.Controls.Add(this.LblHeader);
            this.Panel1.Controls.Add(this.PictureBox5);
            this.Panel1.Controls.Add(this.btnRefresh);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.btnClose);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(727, 44);
            this.Panel1.TabIndex = 141;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.Black;
            this.LblHeader.Location = new System.Drawing.Point(294, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(0, 19);
            this.LblHeader.TabIndex = 135;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(6, 4);
            this.PictureBox5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(33, 34);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 134;
            this.PictureBox5.TabStop = false;
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
            this.Label2.Location = new System.Drawing.Point(34, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(257, 19);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "CALAMITY DAMAGE GENERATE - ";
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
            // comboBoxTypesOfCalamity
            // 
            this.comboBoxTypesOfCalamity.AutoCompleteCustomSource.AddRange(new string[] {
            "Flood",
            "Typhoon",
            "Drought",
            "Ash Fall",
            "Salf intrusion"});
            this.comboBoxTypesOfCalamity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTypesOfCalamity.FormattingEnabled = true;
            this.comboBoxTypesOfCalamity.Items.AddRange(new object[] {
            "Flood",
            "Typhoon",
            "Drought",
            "Ash Fall",
            "Salf intrusion"});
            this.comboBoxTypesOfCalamity.Location = new System.Drawing.Point(535, 67);
            this.comboBoxTypesOfCalamity.Name = "comboBoxTypesOfCalamity";
            this.comboBoxTypesOfCalamity.Size = new System.Drawing.Size(185, 24);
            this.comboBoxTypesOfCalamity.TabIndex = 145;
            this.comboBoxTypesOfCalamity.Visible = false;
            // 
            // comboBoxBudgetF
            // 
            this.comboBoxBudgetF.AutoCompleteCustomSource.AddRange(new string[] {
            "Local Government Unit",
            "Department of Agriculture",
            "Bureau of Fisheries and Aquatic Resources"});
            this.comboBoxBudgetF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBudgetF.FormattingEnabled = true;
            this.comboBoxBudgetF.Items.AddRange(new object[] {
            "Local Government Unit",
            "Department of Agriculture",
            "Bureau of Fisheries and Aquatic Resources"});
            this.comboBoxBudgetF.Location = new System.Drawing.Point(152, 67);
            this.comboBoxBudgetF.Name = "comboBoxBudgetF";
            this.comboBoxBudgetF.Size = new System.Drawing.Size(185, 24);
            this.comboBoxBudgetF.TabIndex = 144;
            // 
            // labelTypesOfCalamity
            // 
            this.labelTypesOfCalamity.AutoSize = true;
            this.labelTypesOfCalamity.Location = new System.Drawing.Point(532, 49);
            this.labelTypesOfCalamity.Name = "labelTypesOfCalamity";
            this.labelTypesOfCalamity.Size = new System.Drawing.Size(105, 16);
            this.labelTypesOfCalamity.TabIndex = 143;
            this.labelTypesOfCalamity.Text = "Type of Calamity :";
            this.labelTypesOfCalamity.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 142;
            this.label11.Text = "Budget From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "Occupation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 149;
            this.label3.Text = "Filter By Full Name :";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(12, 113);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(185, 21);
            this.textBoxFullName.TabIndex = 148;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(12, 620);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(198, 45);
            this.buttonCancel.TabIndex = 152;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(519, 620);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 45);
            this.button6.TabIndex = 153;
            this.button6.Text = "Generate";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 155;
            this.label8.Text = "Calamity Start From:";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(12, 66);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerDateFrom.TabIndex = 154;
            this.dateTimePickerDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerDateFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 156;
            this.label4.Text = "Filter By Address :";
            // 
            // comboBoxOccupation
            // 
            this.comboBoxOccupation.AutoCompleteCustomSource.AddRange(new string[] {
            "FARMER",
            "FARMWORKER/LABORER",
            "FISHERFOLK",
            "AGRI YOUTH"});
            this.comboBoxOccupation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOccupation.FormattingEnabled = true;
            this.comboBoxOccupation.Items.AddRange(new object[] {
            "FARMER",
            "FARMWORKER/LABORER",
            "FISHERFOLK",
            "AGRI YOUTH"});
            this.comboBoxOccupation.Location = new System.Drawing.Point(343, 67);
            this.comboBoxOccupation.Name = "comboBoxOccupation";
            this.comboBoxOccupation.Size = new System.Drawing.Size(186, 24);
            this.comboBoxOccupation.TabIndex = 158;
            this.comboBoxOccupation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOccupation_SelectedIndexChanged);
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "A. Bonifacio (Tinurilan)",
            "Abad Santos (Kambal)",
            "Aguinaldo (Lipata Dako)",
            "Antipolo",
            "Aquino (Imelda)",
            "Bical",
            "Beguin",
            "Bonga",
            "Butag",
            "Cadandanan",
            "Calomagon",
            "Calpi",
            "Cocok-Cabitan",
            "Daganas",
            "Danao",
            "Dolos",
            "E. Quirino (Pinangomhan)",
            "Fabrica",
            "G. Del Pilar (Tanga)",
            "Gate",
            "Inararan",
            "J. Gerona (Biton)",
            "J.P. Laurel (Pon-od)",
            "Jamorawon",
            "Libertad (Calle Putol)",
            "Lajong",
            "Magsaysay (Bongog)",
            "Managa-naga",
            "Marinab",
            "Nasuje",
            "Montecalvario",
            "N. Roque (Calayugan)",
            "Namo",
            "Obrero",
            "Osmeña (Lipata Saday)",
            "Otavi",
            "Padre Diaz",
            "Palale",
            "Quezon (Cabarawan)",
            "R. Gerona (Butag)",
            "Recto",
            "Roxas (Busay)",
            "Sagrada",
            "San Francisco (Polot)",
            "San Isidro (Cabugaan)",
            "San Juan Bag-o",
            "San Juan Daan",
            "San Rafael (Togbongon)",
            "San Ramon",
            "San Vicente",
            "Santa Remedios",
            "Santa Teresita (Trece)",
            "Sigad",
            "Somagongsong",
            "Tarhan",
            "Taromata",
            "Zone 1 (Ilawod)",
            "Zone 2 (Sabang)",
            "Zone 3 (Central)",
            "Zone 4 (Central Business District)",
            "Zone 5 (Canipaan)",
            "Zone 6 (Baybay)",
            "Zone 7 (Iraya)",
            "Zone 8 (Loyo)"});
            this.comboBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Items.AddRange(new object[] {
            "A. Bonifacio (Tinurilan)",
            "Abad Santos (Kambal)",
            "Aguinaldo (Lipata Dako)",
            "Antipolo",
            "Aquino (Imelda)",
            "Bical",
            "Beguin",
            "Bonga",
            "Butag",
            "Cadandanan",
            "Calomagon",
            "Calpi",
            "Cocok-Cabitan",
            "Daganas",
            "Danao",
            "Dolos",
            "E. Quirino (Pinangomhan)",
            "Fabrica",
            "G. Del Pilar (Tanga)",
            "Gate",
            "Inararan",
            "J. Gerona (Biton)",
            "J.P. Laurel (Pon-od)",
            "Jamorawon",
            "Libertad (Calle Putol)",
            "Lajong",
            "Magsaysay (Bongog)",
            "Managa-naga",
            "Marinab",
            "Nasuje",
            "Montecalvario",
            "N. Roque (Calayugan)",
            "Namo",
            "Obrero",
            "Osmeña (Lipata Saday)",
            "Otavi",
            "Padre Diaz",
            "Palale",
            "Quezon (Cabarawan)",
            "R. Gerona (Butag)",
            "Recto",
            "Roxas (Busay)",
            "Sagrada",
            "San Francisco (Polot)",
            "San Isidro (Cabugaan)",
            "San Juan Bag-o",
            "San Juan Daan",
            "San Rafael (Togbongon)",
            "San Ramon",
            "San Vicente",
            "Santa Remedios",
            "Santa Teresita (Trece)",
            "Sigad",
            "Somagongsong",
            "Tarhan",
            "Taromata",
            "Zone 1 (Ilawod)",
            "Zone 2 (Sabang)",
            "Zone 3 (Central)",
            "Zone 4 (Central Business District)",
            "Zone 5 (Canipaan)",
            "Zone 6 (Baybay)",
            "Zone 7 (Iraya)",
            "Zone 8 (Loyo)"});
            this.comboBoxAddress.Location = new System.Drawing.Point(203, 113);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(215, 24);
            this.comboBoxAddress.TabIndex = 159;
            this.comboBoxAddress.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddress_SelectedIndexChanged);
            // 
            // GenerateCalamityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 671);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.comboBoxOccupation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDateFrom);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypesOfCalamity);
            this.Controls.Add(this.comboBoxBudgetF);
            this.Controls.Add(this.labelTypesOfCalamity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GenerateCalamityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateCalamityForm";
            this.Load += new System.EventHandler(this.GenerateCalamityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox5;
        internal System.Windows.Forms.PictureBox btnRefresh;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ComboBox comboBoxTypesOfCalamity;
        private System.Windows.Forms.ComboBox comboBoxBudgetF;
        private System.Windows.Forms.Label labelTypesOfCalamity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.ComboBox comboBoxOccupation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsbsa_id;
        private System.Windows.Forms.ComboBox comboBoxAddress;
    }
}