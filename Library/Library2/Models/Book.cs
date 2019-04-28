using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class Book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string BookName { get; set; }
        // автор книги
        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        public virtual ICollection<Reader> Readers { get; set; }

        public Book()
        {
            Readers = new List<Reader>();
        }

    }
}