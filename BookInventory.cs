using BooksellerApp.Data;
using BooksellerApp.Services;

namespace BooksellerApp
{
    public partial class BookInventory : Form
    {
        private readonly BookRepository _bookRepository;
        SahafDBContext sahafDBContext = new SahafDBContext();
        int userId;
        public BookInventory(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            _bookRepository = new BookRepository(sahafDBContext);
        }
        private void BookInventory_Load(object sender, EventArgs e)
        {
            dgvReport.DataSource = _bookRepository.GetAllBooks();
            cmbOptions.SelectedIndex = 0;
            lblReports2.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd(userId);
            bookAdd.Show();
            this.Hide();
        }
        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            BookUpdateDelete bookUpdateDelete = new BookUpdateDelete(userId);
            bookUpdateDelete.Show();
            this.Hide();
            MessageBox.Show("Please select the row you want to delete and press the 'Delete' button.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;

            switch (cmbOptions.SelectedIndex)
            {
                case 0:
                    dgvReport.DataSource = _bookRepository.GetAllBooks();

                    break;
                case 1:
                    int categoryId = 0;
                    categoryId = (int)cmbOptions2.SelectedValue;
                    dgvReport.DataSource = _bookRepository.GetBooksByCategory(categoryId);
                    break;
                case 2:
                    int authorId = 0;
                    authorId = (int)cmbOptions2.SelectedValue;
                    dgvReport.DataSource = _bookRepository.GetBooksByAuthor(authorId);
                    break;
                case 3:
                    int publisherId = 0;
                    publisherId = (int)cmbOptions2.SelectedValue;
                    dgvReport.DataSource = _bookRepository.GetBooksByPublisher(publisherId);
                    break;
                case 4:
                    int userId = 0;
                    userId = (int)cmbOptions2.SelectedValue;
                    dgvReport.DataSource = _bookRepository.GetBooksUser(userId);
                    break;
                case 5:
                    cmbOptions2.Visible = false;
                    dgvReport.DataSource = _bookRepository.GetLatestBooks();
                    break;
                case 6:
                    if (!decimal.TryParse(txtMaxPrice.Text, out decimal MaxPrice) ||
                       (!decimal.TryParse(txtMinPrice.Text, out decimal MinPrice) ||
                       MaxPrice < 0 || MinPrice < 0 || MinPrice > MaxPrice))
                    {
                        MessageBox.Show("Please enter a valid price.", ("Invalid Price!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        decimal minPrice = 0; decimal maxPrice = 0;
                        cmbOptions2.Visible = false;
                        txtMinPrice.Visible = true;
                        txtMaxPrice.Visible = true;
                        minPrice = Convert.ToDecimal(txtMinPrice.Text);
                        maxPrice = Convert.ToDecimal(txtMaxPrice.Text);
                        dgvReport.DataSource = _bookRepository.GetBooksByPriceRange(minPrice, maxPrice);
                    }
                    break;
            }
        }
        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOptions2.DataSource = null;
            txtMinPrice.Visible = false;
            txtMaxPrice.Visible = false;

            switch (cmbOptions.SelectedIndex)
            {
                case 1: // Kategoriye göre
                    cmbOptions2.Visible = true;
                    cmbOptions2.DataSource = sahafDBContext.Categories.ToList();
                    cmbOptions2.DisplayMember = "CategoryName";
                    cmbOptions2.ValueMember = "CategoryID";
                    lblReports2.Visible = true;
                    lblReports2.Text = "Categories";
                    break;
                case 2: // Yazara göre
                    cmbOptions2.Visible = true;
                    cmbOptions2.DataSource = sahafDBContext.Authors.ToList();
                    cmbOptions2.DisplayMember = "AuthorName";
                    cmbOptions2.ValueMember = "AuthorID";
                    lblReports2.Visible = true;
                    lblReports2.Text = "Authors";
                    break;
                case 3: // Yayıncıya göre
                    cmbOptions2.Visible = true;
                    cmbOptions2.DataSource = sahafDBContext.Publishers.ToList();
                    cmbOptions2.DisplayMember = "PublisherName";
                    cmbOptions2.ValueMember = "PublisherID";
                    lblReports2.Visible = true;
                    lblReports2.Text = "Publishers";
                    break;
                case 4: // Kullanıcıya göre
                    cmbOptions2.Visible = true;
                    cmbOptions2.DataSource = sahafDBContext.Users.ToList();
                    cmbOptions2.DisplayMember = "UserName";
                    cmbOptions2.ValueMember = "UserID";
                    lblReports2.Visible = true;
                    lblReports2.Text = "Users";
                    break;
                case 5: // Son eklenen kitaplar
                    cmbOptions2.Visible = false;
                    lblReports2.Visible = false;
                    break;
                case 6: // Fiyat aralığına göre
                    cmbOptions2.Visible = false;
                    txtMinPrice.Visible = true;
                    txtMaxPrice.Visible = true;
                    lblReports2.Visible = false;
                    break;
                default:
                    cmbOptions2.Visible = false;
                    break;
            }
        }
        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
