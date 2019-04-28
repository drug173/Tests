using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class Reader
    {
        public int ReaderId { get; set; }
        
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public Reader()
        {
            Books = new List<Book>();
        }
    }
}