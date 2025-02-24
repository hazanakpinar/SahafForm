using BooksellerApp.Data;
using BooksellerApp.Services;

namespace BooksellerApp
{
    public partial class BookUpdateDelete : Form
    {
        private readonly BookRepository _bookRepository;
        SahafDBContext sahafDBContext = new SahafDBContext();
        int userId;
        int bookId;
        public BookUpdateDelete(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            _bookRepository = new BookRepository(sahafDBContext);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BookInventory bookInventory = new BookInventory(userId);
            bookInventory.Show();
            this.Hide();
        }
        private void BookUpdateDelete_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = _bookRepository.GetAllBooks();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure want to delete selected book? ", "Deleted Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookId"].Value);
                    _bookRepository.ForDelete(bookId);
                    sahafDBContext.SaveChanges();
                    dgvBooks.DataSource = _bookRepository.GetAllBooks();
                    MessageBox.Show("Selected book deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select want to delete row.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookId"].Value);
                UpdateBook updateBook = new UpdateBook(bookId, userId);
                updateBook.Show();
                this.Hide();
            }
        }
    }
}