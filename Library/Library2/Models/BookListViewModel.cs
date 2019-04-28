using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library2.Models
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public SelectList Authors { get; set; }
        
    }
}