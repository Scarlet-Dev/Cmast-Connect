using CMASTConnect.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.Models.Search
{
    public class PostSearch : Post
    {
        //public PostSearch(int id, string title, string[] category, string author,
        //    DateTime publishedDate, string updatedBy, DateTime updatedOn)
        //{
        //    Id = id;
        //    Title = title;
        //    Category = category;
        //    Author = author;
        //    PublishedDate = publishedDate;
        //    UpdatedBy = updatedBy;
        //    UpdatedOn = updatedOn;
        //}

        public PostSearch(int id, string title, string[] category, string author, bool isPublished, DateTime publishedDate, 
            string updatedBy, DateTime updatedOn) : base(id, title, category, author, isPublished, publishedDate, updatedBy, updatedOn)
        {
        }

        public new int Id { get; }
        public new string Title { get; }
        public new string[] Category { get; }
        public new string Author { get; }
        public new DateTime PublishedDate { get; }
        public new string UpdatedBy { get; }
        public new DateTime UpdatedOn { get; }
    }
}
