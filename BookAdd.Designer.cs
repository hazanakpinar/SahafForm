namespace BooksellerApp
{
    partial class BookAdd
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblPublisher = new Label();
            lblCategory = new Label();
            lblPublicationYear = new Label();
            lblEditionNumber = new Label();
            lblPrice = new Label();
            lblSummary = new Label();
            cmbPublisher = new ComboBox();
            cmbCategory = new ComboBox();
            txtTitle = new TextBox();
            txtAddAuthorName = new TextBox();
            txtAddPublisherName = new TextBox();
            txtPrice = new TextBox();
            txtSummary = new RichTextBox();
            lnklblAuthorName = new LinkLabel();
            lnklblPublisherName = new LinkLabel();
            btnAuthorAdd = new Button();
            btnPublisherAdd = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtPublicationYear = new TextBox();
            txtEditionNumber = new TextBox();
            btnBack = new Button();
            clbAuthors = new CheckedListBox();
            pictureBox1 = new PictureBox();
            lblBookAdd = new Label();
            picboxBackground = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxBackground).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblTitle.Location = new Point(134, 98);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.None;
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = SystemColors.Control;
            lblAuthor.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblAuthor.Location = new Point(134, 144);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 19);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            lblPublisher.Anchor = AnchorStyles.None;
            lblPublisher.AutoSize = true;
            lblPublisher.BackColor = SystemColors.Control;
            lblPublisher.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPublisher.Location = new Point(134, 295);
            lblPublisher.Margin = new Padding(2, 0, 2, 0);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(83, 19);
            lblPublisher.TabIndex = 0;
            lblPublisher.Text = "Publisher";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.BackColor = SystemColors.Control;
            lblCategory.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblCategory.Location = new Point(134, 338);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 19);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // lblPublicationYear
            // 
            lblPublicationYear.Anchor = AnchorStyles.None;
            lblPublicationYear.AutoSize = true;
            lblPublicationYear.BackColor = SystemColors.Control;
            lblPublicationYear.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPublicationYear.Location = new Point(134, 379);
            lblPublicationYear.Margin = new Padding(2, 0, 2, 0);
            lblPublicationYear.Name = "lblPublicationYear";
            lblPublicationYear.Size = new Size(135, 19);
            lblPublicationYear.TabIndex = 0;
            lblPublicationYear.Text = "Publication Year";
            // 
            // lblEditionNumber
            // 
            lblEditionNumber.Anchor = AnchorStyles.None;
            lblEditionNumber.AutoSize = true;
            lblEditionNumber.BackColor = SystemColors.Control;
            lblEditionNumber.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblEditionNumber.Location = new Point(134, 418);
            lblEditionNumber.Margin = new Padding(2, 0, 2, 0);
            lblEditionNumber.Name = "lblEditionNumber";
            lblEditionNumber.Size = new Size(131, 19);
            lblEditionNumber.TabIndex = 0;
            lblEditionNumber.Text = "Edition Number";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.Control;
            lblPrice.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPrice.Location = new Point(134, 463);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 19);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.None;
            lblSummary.AutoSize = true;
            lblSummary.BackColor = SystemColors.Control;
            lblSummary.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblSummary.Location = new Point(134, 503);
            lblSummary.Margin = new Padding(2, 0, 2, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(83, 19);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Summary";
            // 
            // cmbPublisher
            // 
            cmbPublisher.Anchor = AnchorStyles.None;
            cmbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPublisher.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            cmbPublisher.ForeColor = Color.Black;
            cmbPublisher.FormattingEnabled = true;
            cmbPublisher.Location = new Point(298, 291);
            cmbPublisher.Margin = new Padding(2, 1, 2, 1);
            cmbPublisher.Name = "cmbPublisher";
            cmbPublisher.Size = new Size(215, 27);
            cmbPublisher.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(298, 334);
            cmbCategory.Margin = new Padding(2, 1, 2, 1);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(215, 27);
            cmbCategory.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(298, 95);
            txtTitle.Margin = new Padding(2, 1, 2, 1);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Enter a Title";
            txtTitle.Size = new Size(215, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtAddAuthorName
            // 
            txtAddAuthorName.Anchor = AnchorStyles.None;
            txtAddAuthorName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtAddAuthorName.ForeColor = Color.Black;
            txtAddAuthorName.Location = new Point(740, 140);
            txtAddAuthorName.Margin = new Padding(2, 1, 2, 1);
            txtAddAuthorName.Name = "txtAddAuthorName";
            txtAddAuthorName.PlaceholderText = "Enter Author Name";
            txtAddAuthorName.Size = new Size(210, 27);
            txtAddAuthorName.TabIndex = 9;
            txtAddAuthorName.Visible = false;
            // 
            // txtAddPublisherName
            // 
            txtAddPublisherName.Anchor = AnchorStyles.None;
            txtAddPublisherName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtAddPublisherName.ForeColor = Color.Black;
            txtAddPublisherName.Location = new Point(740, 291);
            txtAddPublisherName.Margin = new Padding(2, 1, 2, 1);
            txtAddPublisherName.Name = "txtAddPublisherName";
            txtAddPublisherName.PlaceholderText = "Enter Publisher Name";
            txtAddPublisherName.Size = new Size(210, 27);
            txtAddPublisherName.TabIndex = 11;
            txtAddPublisherName.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(298, 460);
            txtPrice.Margin = new Padding(2, 1, 2, 1);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter Price";
            txtPrice.Size = new Size(215, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtSummary
            // 
            txtSummary.Anchor = AnchorStyles.None;
            txtSummary.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtSummary.ForeColor = Color.Black;
            txtSummary.Location = new Point(298, 503);
            txtSummary.Margin = new Padding(2, 1, 2, 1);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(215, 114);
            txtSummary.TabIndex = 8;
            txtSummary.Text = "";
            // 
            // lnklblAuthorName
            // 
            lnklblAuthorName.Anchor = AnchorStyles.None;
            lnklblAuthorName.AutoSize = true;
            lnklblAuthorName.BackColor = SystemColors.Control;
            lnklblAuthorName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lnklblAuthorName.Location = new Point(517, 144);
            lnklblAuthorName.Margin = new Padding(2, 0, 2, 0);
            lnklblAuthorName.Name = "lnklblAuthorName";
            lnklblAuthorName.Size = new Size(157, 19);
            lnklblAuthorName.TabIndex = 4;
            lnklblAuthorName.TabStop = true;
            lnklblAuthorName.Text = "Author Unavailable";
            lnklblAuthorName.LinkClicked += lnklblAuthorName_LinkClicked;
            // 
            // lnklblPublisherName
            // 
            lnklblPublisherName.Anchor = AnchorStyles.None;
            lnklblPublisherName.AutoSize = true;
            lnklblPublisherName.BackColor = SystemColors.Control;
            lnklblPublisherName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lnklblPublisherName.Location = new Point(517, 295);
            lnklblPublisherName.Margin = new Padding(2, 0, 2, 0);
            lnklblPublisherName.Name = "lnklblPublisherName";
            lnklblPublisherName.Size = new Size(177, 19);
            lnklblPublisherName.TabIndex = 4;
            lnklblPublisherName.TabStop = true;
            lnklblPublisherName.Text = "Publisher Unavailable";
            lnklblPublisherName.LinkClicked += lnklblPublisherName_LinkClicked;
            // 
            // btnAuthorAdd
            // 
            btnAuthorAdd.Anchor = AnchorStyles.None;
            btnAuthorAdd.BackColor = Color.FromArgb(63, 255, 0);
            btnAuthorAdd.Cursor = Cursors.Hand;
            btnAuthorAdd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnAuthorAdd.ForeColor = Color.White;
            btnAuthorAdd.Location = new Point(772, 185);
            btnAuthorAdd.Margin = new Padding(2, 1, 2, 1);
            btnAuthorAdd.Name = "btnAuthorAdd";
            btnAuthorAdd.Size = new Size(178, 41);
            btnAuthorAdd.TabIndex = 10;
            btnAuthorAdd.Text = "Author Add";
            btnAuthorAdd.UseVisualStyleBackColor = false;
            btnAuthorAdd.Visible = false;
            btnAuthorAdd.Click += btnAuthorAdd_Click;
            // 
            // btnPublisherAdd
            // 
            btnPublisherAdd.Anchor = AnchorStyles.None;
            btnPublisherAdd.BackColor = Color.FromArgb(63, 255, 0);
            btnPublisherAdd.Cursor = Cursors.Hand;
            btnPublisherAdd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnPublisherAdd.ForeColor = Color.White;
            btnPublisherAdd.Location = new Point(772, 334);
            btnPublisherAdd.Margin = new Padding(2, 1, 2, 1);
            btnPublisherAdd.Name = "btnPublisherAdd";
            btnPublisherAdd.Size = new Size(178, 41);
            btnPublisherAdd.TabIndex = 12;
            btnPublisherAdd.Text = "Publisher Add";
            btnPublisherAdd.UseVisualStyleBackColor = false;
            btnPublisherAdd.Visible = false;
            btnPublisherAdd.Click += btnPublisherAdd_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(63, 255, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(335, 646);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnBookAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-299, 271);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Anchor = AnchorStyles.None;
            txtPublicationYear.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtPublicationYear.ForeColor = Color.Black;
            txtPublicationYear.Location = new Point(298, 376);
            txtPublicationYear.Margin = new Padding(2, 1, 2, 1);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.PlaceholderText = "Enter Publication Year";
            txtPublicationYear.Size = new Size(215, 27);
            txtPublicationYear.TabIndex = 5;
            // 
            // txtEditionNumber
            // 
            txtEditionNumber.Anchor = AnchorStyles.None;
            txtEditionNumber.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtEditionNumber.ForeColor = Color.Black;
            txtEditionNumber.Location = new Point(298, 415);
            txtEditionNumber.Margin = new Padding(2, 1, 2, 1);
            txtEditionNumber.Name = "txtEditionNumber";
            txtEditionNumber.PlaceholderText = "Enter Edition Number";
            txtEditionNumber.Size = new Size(215, 27);
            txtEditionNumber.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = SystemColors.Control;
            btnBack.BackgroundImage = Properties.Resources.backButton;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(11, 683);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 60);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // clbAuthors
            // 
            clbAuthors.Anchor = AnchorStyles.None;
            clbAuthors.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            clbAuthors.ForeColor = Color.Black;
            clbAuthors.FormattingEnabled = true;
            clbAuthors.Location = new Point(298, 144);
            clbAuthors.Margin = new Padding(3, 4, 3, 4);
            clbAuthors.Name = "clbAuthors";
            clbAuthors.Size = new Size(215, 114);
            clbAuthors.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.bookAddButton;
            pictureBox1.Location = new Point(388, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblBookAdd
            // 
            lblBookAdd.Anchor = AnchorStyles.None;
            lblBookAdd.AutoSize = true;
            lblBookAdd.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBookAdd.Location = new Point(450, 9);
            lblBookAdd.Name = "lblBookAdd";
            lblBookAdd.Size = new Size(234, 35);
            lblBookAdd.TabIndex = 16;
            lblBookAdd.Text = "Add Book Page";
            // 
            // picboxBackground
            // 
            picboxBackground.Anchor = AnchorStyles.None;
            picboxBackground.BackColor = SystemColors.Control;
            picboxBackground.Location = new Point(96, 50);
            picboxBackground.Name = "picboxBackground";
            picboxBackground.Size = new Size(894, 650);
            picboxBackground.TabIndex = 17;
            picboxBackground.TabStop = false;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1082, 753);
            Controls.Add(lblBookAdd);
            Controls.Add(pictureBox1);
            Controls.Add(clbAuthors);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(btnPublisherAdd);
            Controls.Add(btnAuthorAdd);
            Controls.Add(lnklblPublisherName);
            Controls.Add(lnklblAuthorName);
            Controls.Add(txtSummary);
            Controls.Add(txtPrice);
            Controls.Add(txtEditionNumber);
            Controls.Add(txtPublicationYear);
            Controls.Add(txtAddPublisherName);
            Controls.Add(txtAddAuthorName);
            Controls.Add(txtTitle);
            Controls.Add(cmbPublisher);
            Controls.Add(cmbCategory);
            Controls.Add(label1);
            Controls.Add(lblSummary);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblEditionNumber);
            Controls.Add(lblPublisher);
            Controls.Add(lblPublicationYear);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(picboxBackground);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "BookAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookAdd";
            Load += BookActions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblCategory;
        private Label lblPublicationYear;
        private Label lblEditionNumber;
        private Label lblPrice;
        private Label lblSummary;
        private ComboBox cmbPublisher;
        private ComboBox cmbCategory;
        private TextBox txtTitle;
        private TextBox txtAddAuthorName;
        private TextBox txtAddPublisherName;
        private TextBox txtPrice;
        private RichTextBox txtSummary;
        private LinkLabel lnklblAuthorName;
        private LinkLabel lnklblPublisherName;
        private Button btnAuthorAdd;
        private Button btnPublisherAdd;
        private Button btnAdd;
        private Label label1;
        private TextBox txtPublicationYear;
        private TextBox txtEditionNumber;
        private Button btnBack;
        private CheckedListBox clbAuthors;
        private PictureBox pictureBox1;
        private Label lblBookAdd;
        private PictureBox picboxBackground;
    }
}