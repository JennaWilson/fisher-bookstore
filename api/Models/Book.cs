using System;

namespace Fisher.Bookstore.Api
{
    public class Book 
    {
        internal int Id;
        internal string Author;
        internal string ISBN;

        public int BookID { get; set; }

        public string Title { get; set; }

    }
}