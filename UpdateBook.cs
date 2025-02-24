using BooksellerApp.Data;
using BooksellerApp.Models;
using BooksellerApp.Services;
using System.Data;

namespace BooksellerApp
{
    public partial class UpdateBook : Form
    {
        private readonly BookRepository _bookRepository;
        private readonly Book_AuthorRepository _bookAuthorRepository;
        private readonly AuthorRepository _authorRepository;
        private readonly PublisherRepository _publisherRepository;

        SahafDBContext sahafDBContext = new SahafDBContext();
        int bookId;
        int userId;
        public UpdateBook(int bookId, int userId)
        {
            InitializeComponent();
            this.bookId = bookId;
            this.userId = userId;
            _bookRepository = new BookRepository(sahafDBContext);
            _bookAuthorRepository = new Book_AuthorRepository(sahafDBContext);
            _authorRepository = new AuthorRepository(sahafDBContext);
            _publisherRepository = new PublisherRepository(sahafDBContext);
        }
        private void UpdateBook_Load(object sender, EventArgs e)
        {
            var book = _bookRepository.ForSearch(bookId);

            txtUpdateTitle.Text = book.Title;
            txtUpdatePublicationYear.Text = Convert.ToString(book.PublicationYear);
            txtUpdatePrice.Text = Convert.ToString(book.Price);
            txtUpdateEditionNumber.Text = Convert.ToString(book.EditionNumber);
            txtUpdateSummary.Text = book.Summary;

            clbUpdateAuthors.DataSource = sahafDBContext.Authors.ToList();
            clbUpdateAuthors.DisplayMember = "AuthorName";

            var selectedAuthorIds = sahafDBContext.BookAuthors.Where(ba => ba.BookID == bookId)
                                                        .Select(ba => ba.AuthorID)
                                                        .ToList();

            // CheckedListBox'ta yazarları seçili hale getir
            for (int i = 0; i < clbUpdateAuthors.Items.Count; i++)
            {
                var author = clbUpdateAuthors.Items[i] as Author;
                if (author != null && selectedAuthorIds.Contains(author.AuthorID))
                {
                    clbUpdateAuthors.SetItemChecked(i, true);
                }
            }
            cmbUpdateCategory.DataSource = sahafDBContext.Categories.ToList();
            cmbUpdateCategory.DisplayMember = "CategoryName";
            cmbUpdateCategory.ValueMember = "CategoryId";
            cmbUpdateCategory.SelectedValue = book.CategoryID;

            cmbUpdatePublisher.DataSource = sahafDBContext.Publishers.ToList();
            cmbUpdatePublisher.DisplayMember = "PublisherName";
            cmbUpdatePublisher.ValueMember = "PublisherId";
            cmbUpdatePublisher.SelectedValue = book.PublisherID;
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateTitle.Text) ||
                string.IsNullOrWhiteSpace(txtUpdatePublicationYear.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateEditionNumber.Text) ||
                string.IsNullOrWhiteSpace(txtUpdatePrice.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateSummary.Text))
            {
                MessageBox.Show("Please fill the all fields.", ("Invalid Values!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!short.TryParse(txtUpdatePublicationYear.Text, out short PublicationYear) ||
                      short.Parse(txtUpdatePublicationYear.Text) < 0)
            {
                MessageBox.Show("Please enter a valid publication year.", ("Invalid Publication Year!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtUpdateEditionNumber.Text, out int EditionNumber) ||
                      int.Parse(txtUpdateEditionNumber.Text) < 0)
            {
                MessageBox.Show("Please enter a valid edition number.", ("Invalid Edition Number!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!decimal.TryParse(txtUpdatePrice.Text, out decimal Price) ||
                     decimal.Parse(txtUpdatePrice.Text) < 0)
            {
                MessageBox.Show("Please enter a valid price.", ("Invalid Price!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (clbUpdateAuthors.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one Author from the list.", "No Item Selected!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Book updatedBook = new Book()
                {
                    BookID = this.bookId,
                    Title = txtUpdateTitle.Text,
                    PublicationYear = short.Parse(txtUpdatePublicationYear.Text),
                    EditionNumber = int.Parse(txtUpdateEditionNumber.Text),
                    Price = decimal.Parse(txtUpdatePrice.Text),
                    Summary = txtUpdateSummary.Text,
                    CategoryID = (int)cmbUpdateCategory.SelectedValue,
                    PublisherID = (int)cmbUpdatePublisher.SelectedValue,
                    UserID = userId
                };

                _bookRepository.UpdateBook(updatedBook);

                // Verilen KitapID için mevcut olan tüm kitap-yazar ilişkilerini getirir.
                var listBookAuthor = _bookAuthorRepository.GetAllBookAuthors()
                                                           .Where(x => x.BookID == updatedBook.BookID)
                                                           .ToList();

                // CheckedListBox'tan seçili yazarları getirir.
                var selectedAuthors = clbUpdateAuthors.CheckedItems.Cast<Author>().ToList();

                // Yazar listesinde seçili olmayan yazarları kaldırır.
                var authorsToRemove = listBookAuthor.Where(existingAuthor => !selectedAuthors.Any(selectedAuthor => selectedAuthor.AuthorID == existingAuthor.AuthorID)).ToList();
                foreach (var authorToRemove in authorsToRemove)
                {
                    _bookAuthorRepository.ForDelete(authorToRemove.Book_AuthorID);
                }

                // Listedeki yazarları ekler yada günceller.
                foreach (var selectedAuthor in selectedAuthors)
                {
                    var existingAuthor = listBookAuthor.FirstOrDefault(x => x.AuthorID == selectedAuthor.AuthorID);

                    if (existingAuthor is null)
                    {
                        // Eğer listede yazar mevcut değilse yenisini ekler.
                        var newBookAuthor = new Book_Author
                        {
                            BookID = updatedBook.BookID,
                            AuthorID = selectedAuthor.AuthorID
                        };
                        _bookAuthorRepository.ForAdd(newBookAuthor);
                    }
                    else
                    {

                    }
                }
                MessageBox.Show("Book Updated Succesful");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookUpdateDelete bookUpdateDelete = new BookUpdateDelete(userId);
            bookUpdateDelete.Show();
            this.Hide();
        }
        private void lnklblAuthorUnavailable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUpdateNewAuthor.Visible = true;
            btnAddNewAuthor.Visible = true;
        }
        private void lnklblPublisherAvailable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUpdateNewPublisher.Visible = true;
            btnAddNewPublisher.Visible = true;
        }
        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author() { AuthorName = txtUpdateNewAuthor.Text };
            _authorRepository.ForAdd(author);
            clbUpdateAuthors.DataSource = sahafDBContext.Authors.ToList();
            MessageBox.Show("Author Added.");
            txtUpdateNewAuthor.Visible = false;
            btnAddNewAuthor.Visible = false;
        }
        private void btnAddNewPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher() { PublisherName = txtUpdateNewPublisher.Text };
            _publisherRepository.ForAdd(publisher);
            cmbUpdatePublisher.DataSource = sahafDBContext.Publishers.ToList();
            MessageBox.Show("Publisher Added.");
            txtUpdateNewPublisher.Visible = false;
            btnAddNewPublisher.Visible = false;
        }
    }
}



