namespace BooksellerApp
{
    partial class BookInventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnUpdateDelete = new Button();
            btnAdd = new Button();
            lblReports = new Label();
            cmbOptions = new ComboBox();
            cmbOptions2 = new ComboBox();
            btnSearch = new Button();
            dgvReport = new DataGridView();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            btnBackLogin = new Button();
            lblReports2 = new Label();
            lblBookInventory = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateDelete
            // 
            btnUpdateDelete.Anchor = AnchorStyles.None;
            btnUpdateDelete.BackColor = Color.DarkGray;
            btnUpdateDelete.Cursor = Cursors.Hand;
            btnUpdateDelete.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnUpdateDelete.ForeColor = Color.White;
            btnUpdateDelete.Location = new Point(711, 704);
            btnUpdateDelete.Margin = new Padding(2, 1, 2, 1);
            btnUpdateDelete.Name = "btnUpdateDelete";
            btnUpdateDelete.Size = new Size(178, 41);
            btnUpdateDelete.TabIndex = 4;
            btnUpdateDelete.Text = "Update/Delete";
            btnUpdateDelete.UseVisualStyleBackColor = false;
            btnUpdateDelete.Click += btnUpdateDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(63, 255, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(893, 704);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblReports
            // 
            lblReports.Anchor = AnchorStyles.None;
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblReports.Location = new Point(154, 557);
            lblReports.Margin = new Padding(2, 0, 2, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(72, 19);
            lblReports.TabIndex = 4;
            lblReports.Text = "Reports";
            // 
            // cmbOptions
            // 
            cmbOptions.Anchor = AnchorStyles.None;
            cmbOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOptions.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            cmbOptions.ForeColor = Color.Black;
            cmbOptions.FormattingEnabled = true;
            cmbOptions.Items.AddRange(new object[] { "GetAllBookList", "BookListbyCategory", "BookListbyAuthor", "BookListbyPublisher", "BooksAddedbyUsers", "Last10AddedBooks", "BookListbyPrice" });
            cmbOptions.Location = new Point(285, 553);
            cmbOptions.Margin = new Padding(2, 1, 2, 1);
            cmbOptions.Name = "cmbOptions";
            cmbOptions.Size = new Size(264, 27);
            cmbOptions.TabIndex = 1;
            cmbOptions.SelectedIndexChanged += cmbOptions_SelectedIndexChanged;
            // 
            // cmbOptions2
            // 
            cmbOptions2.Anchor = AnchorStyles.None;
            cmbOptions2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOptions2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            cmbOptions2.ForeColor = Color.Black;
            cmbOptions2.FormattingEnabled = true;
            cmbOptions2.Location = new Point(285, 601);
            cmbOptions2.Margin = new Padding(2, 1, 2, 1);
            cmbOptions2.Name = "cmbOptions2";
            cmbOptions2.Size = new Size(264, 27);
            cmbOptions2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.BackgroundImage = Properties.Resources.searchButton;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(469, 643);
            btnSearch.Margin = new Padding(2, 1, 2, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 60);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.None;
            dgvReport.BackgroundColor = SystemColors.Control;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.Location = new Point(12, 59);
            dgvReport.Margin = new Padding(2, 1, 2, 1);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 82;
            dgvReport.Size = new Size(1059, 479);
            dgvReport.TabIndex = 5;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtMinPrice.ForeColor = Color.Black;
            txtMinPrice.Location = new Point(564, 554);
            txtMinPrice.Margin = new Padding(2, 1, 2, 1);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Min";
            txtMinPrice.Size = new Size(125, 27);
            txtMinPrice.TabIndex = 6;
            txtMinPrice.Visible = false;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtMaxPrice.ForeColor = Color.Black;
            txtMaxPrice.Location = new Point(693, 554);
            txtMaxPrice.Margin = new Padding(2, 1, 2, 1);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "Max";
            txtMaxPrice.Size = new Size(125, 27);
            txtMaxPrice.TabIndex = 7;
            txtMaxPrice.Visible = false;
            // 
            // btnBackLogin
            // 
            btnBackLogin.Anchor = AnchorStyles.None;
            btnBackLogin.BackColor = SystemColors.Control;
            btnBackLogin.BackgroundImage = Properties.Resources.backButton;
            btnBackLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackLogin.Cursor = Cursors.Hand;
            btnBackLogin.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnBackLogin.Location = new Point(11, 683);
            btnBackLogin.Margin = new Padding(3, 4, 3, 4);
            btnBackLogin.Name = "btnBackLogin";
            btnBackLogin.Size = new Size(80, 60);
            btnBackLogin.TabIndex = 8;
            btnBackLogin.UseVisualStyleBackColor = false;
            btnBackLogin.Click += btnBackLogin_Click;
            // 
            // lblReports2
            // 
            lblReports2.Anchor = AnchorStyles.None;
            lblReports2.AutoSize = true;
            lblReports2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblReports2.Location = new Point(154, 605);
            lblReports2.Margin = new Padding(2, 0, 2, 0);
            lblReports2.Name = "lblReports2";
            lblReports2.Size = new Size(81, 19);
            lblReports2.TabIndex = 4;
            lblReports2.Text = "Reports2";
            // 
            // lblBookInventory
            // 
            lblBookInventory.Anchor = AnchorStyles.None;
            lblBookInventory.AutoSize = true;
            lblBookInventory.BackColor = Color.Lavender;
            lblBookInventory.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBookInventory.Location = new Point(450, 9);
            lblBookInventory.Name = "lblBookInventory";
            lblBookInventory.Size = new Size(311, 35);
            lblBookInventory.TabIndex = 8;
            lblBookInventory.Text = "Book Inventory Page";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.bookInventoryIcon;
            pictureBox1.Location = new Point(388, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1082, 753);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(lblBookInventory);
            Controls.Add(btnBackLogin);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(dgvReport);
            Controls.Add(cmbOptions2);
            Controls.Add(cmbOptions);
            Controls.Add(lblReports2);
            Controls.Add(lblReports);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdateDelete);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BookInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateDelete;
        private Button btnAdd;
        private Label lblReports;
        private ComboBox cmbOptions;
        private ComboBox cmbOptions2;
        private Button btnSearch;
        private DataGridView dgvReport;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private Button btnBackLogin;
        private Label lblReports2;
        private Label lblBookInventory;
        private PictureBox pictureBox1;
    }
}