using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.Models.Search
{
    public class PostSearch
    {
        public string Title { get; set; }

        public string[] Category { get; set; }

        public string Author { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
