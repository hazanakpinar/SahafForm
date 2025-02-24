namespace BooksellerApp.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public  string? EmployeeName { get; set; }
        public  string? EmployeeSurname { get; set; }
        public  string Password { get; set; }
      
        //Navigation Property
        public ICollection<Book>? Books { get; set; }
        public override string ToString()
        {
            return UserName.ToString();
        }
    }
}
