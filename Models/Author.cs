namespace BooksellerApp.Models
{
    internal class Author
    {
        public  int AuthorID { get; set; }
        public  string AuthorName { get; set; }

        // Navigation Property
        public ICollection<Book_Author>? Book_Authors{ get; set; }
        public override string ToString()
        {
            return AuthorName.ToString();
        }
    }
}
