namespace BooksellerApp.Models
{
    internal class Book_Author
    {
        public int Book_AuthorID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }

        // Foreign Key
        public  Book? Book { get; set; }
        public  Author? Author { get; set; }
    }
}
