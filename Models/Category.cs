﻿namespace BooksellerApp.Models
{
    internal class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // Navigation Property
        public ICollection<Book>? Books { get; set; }
        public override string ToString()
        {
            return CategoryName.ToString();
        }
    }
}
