using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class Author
    {
        // ID автора
        public int Id { get; set; }
        // автор книги
        public string NameAuthor { get; set; }

        public ICollection<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
}