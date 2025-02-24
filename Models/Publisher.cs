namespace BooksellerApp.Models
{
    internal class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }

        // Navigation Property
        public ICollection<Book>? Books { get; set; }
        public override string ToString()
        {
            return PublisherName.ToString();
        }
    }
}
