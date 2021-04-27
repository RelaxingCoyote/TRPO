using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibraryApp.Models
{
    public class Book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // издатель
        public string Publisher { get; set; }
        // дата издания книги
        public DateTime PubDate { get; set; }
    }
}