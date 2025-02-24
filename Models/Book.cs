namespace BooksellerApp.Models
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public short PublicationYear { get; set; }
        public int EditionNumber { get; set; }
        public string Summary { get; set; }

        // Foreign Key
        public int PublisherID { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        // Navigation Property
        public Publisher? Publisher { get; set; }
        public Category? Category { get; set; }
        public User? User { get; set; }
        public ICollection<Book_Author>? Book_Authors { get; set; }
    }
}
