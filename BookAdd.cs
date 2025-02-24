using Microsoft.EntityFrameworkCore;
using BooksellerApp.Data;
using BooksellerApp.Models;
using BooksellerApp.Services;
using System.Windows.Forms;

namespace BooksellerApp
{
    public partial class BookAdd : Form
    {
        SahafDBContext sahafDBContext = new SahafDBContext();
        private readonly BookRepository _bookRepository;
        private readonly Book_AuthorRepository _bookAuthorRepository;
        private readonly AuthorRepository _authorRepository;
        private readonly PublisherRepository _publisherRepository;
        int userId;
        public BookAdd(int userId)
        {
            _bookRepository = new BookRepository(sahafDBContext);
            _bookAuthorRepository = new Book_AuthorRepository(sahafDBContext);
            _authorRepository = new AuthorRepository(sahafDBContext);
            _publisherRepository = new PublisherRepository(sahafDBContext);
            InitializeComponent();
            this.userId = userId;
        }
        //Kitap ekleme butonuna basıldığında gerçekleşecek işlemler
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtPublicationYear.Text) ||
                string.IsNullOrWhiteSpace(txtEditionNumber.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Please fill the all fields.", ("Invalid Values!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!short.TryParse(txtPublicationYear.Text, out short PublicationYear) ||
                      short.Parse(txtPublicationYear.Text) < 0)
            {
                MessageBox.Show("Please enter a valid publication year.", ("Invalid Publication Year!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtEditionNumber.Text, out int EditionNumber) ||
                      int.Parse(txtEditionNumber.Text) < 0)
            {
                MessageBox.Show("Please enter a valid edition number.", ("Invalid Edition Number!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!decimal.TryParse(txtPrice.Text, out decimal Price) ||
                     decimal.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show("Please enter a valid price.", ("Invalid Price!!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (clbAuthors.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one Author from the list.", "No Item Selected!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sahafDBContext.Books.Include(x => x.Publisher);
                Book book = new Book()
                {
                    Title = txtTitle.Text,
                    PublicationYear = short.Parse(txtPublicationYear.Text),
                    EditionNumber = int.Parse(txtEditionNumber.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    Summary = txtSummary.Text,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    PublisherID = (int)cmbPublisher.SelectedValue,
                    UserID = userId,
                };
                _bookRepository.ForAdd(book);
                var selectedItems = clbAuthors.CheckedItems;
                foreach (var selectedItem in selectedItems)
                {
                    if (selectedItem is Author author)
                    {
                        Book_Author book_Author = new Book_Author()
                        {
                            AuthorID = author.AuthorID,
                            BookID = book.BookID
                        };
                        _bookAuthorRepository.ForAdd(book_Author);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Author.");
                    }
                }
                MessageBox.Show("Book added.");
            }
        }

        //Yeni yazar ekleme işlemi
        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            Author author = new Author() { AuthorName = txtAddAuthorName.Text };
            _authorRepository.ForAdd(author);
            clbAuthors.DataSource = sahafDBContext.Authors.ToList();
            MessageBox.Show("Author Added.");
            txtAddAuthorName.Visible = false;
            btnAuthorAdd.Visible = false;
        }

        //Yeni yayınevi ekleme işlemi
        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher() { PublisherName = txtAddPublisherName.Text };
            _publisherRepository.ForAdd(publisher);
            cmbPublisher.DataSource = sahafDBContext.Publishers.ToList();
            MessageBox.Show("Publisher Added.");
            txtAddPublisherName.Visible = false;
            btnPublisherAdd.Visible = false;
        }

        private void BookActions_Load(object sender, EventArgs e)
        {

            cmbPublisher.DataSource = sahafDBContext.Publishers.ToList();
            cmbPublisher.DisplayMember = "PublisherName";
            cmbPublisher.ValueMember = "PublisherID";

            cmbCategory.DataSource = sahafDBContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            clbAuthors.DisplayMember = "AuthorName";

            foreach (Author item in sahafDBContext.Authors.ToList())
            {
                clbAuthors.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookInventory bookInventory = new BookInventory(userId);
            this.Hide();
            bookInventory.Show();
        }

        private void lnklblAuthorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAddAuthorName.Visible = true;
            btnAuthorAdd.Visible = true;
        }

        private void lnklblPublisherName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAddPublisherName.Visible = true;
            btnPublisherAdd.Visible = true;
        }
    }
}

