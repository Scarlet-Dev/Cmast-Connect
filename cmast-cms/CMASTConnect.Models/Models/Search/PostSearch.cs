using CMASTConnect.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.Models.Search
{
    public class PostSearch : Post
    {
        

        public PostSearch(int id, string title, string[] category, string author,
            DateTime publishedDate, string updatedBy, DateTime updatedOn) : 
            base(id, title, category, author,publishedDate, updatedBy, updatedOn)
        {

        }
    }
}
