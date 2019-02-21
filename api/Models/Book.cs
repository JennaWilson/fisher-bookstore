using System;

namespace Fisher.Bookstore.Api
{
    public class Book 
    {
        public int Id;
        public string Author;
        public string ISBN;

        public int BookID { get; set; }

        public string Title { get; set; }

    }
}