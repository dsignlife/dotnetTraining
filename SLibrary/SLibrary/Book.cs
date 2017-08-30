using System;

namespace SLibrary
{
    public class Book
    {
        public Book()
        {
        }

        public string Isbn { get; set; }
        public int Copynumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Statistics { get; set; }
        public DateTime Borrowdate { get; set; }
        public DateTime Returndate { get; set; }
        public int Librarycardnumber { get; set; }
    }
}