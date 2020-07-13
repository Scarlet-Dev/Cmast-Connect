using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMASTConnect.Models.DTO
{
    public class Post
    {
        public int Id { get; }

        public string Title { get; }

        public string[] Category { get; }

        public string Author { get; }

        public bool IsPublished { get; }

        public DateTime PublishedDate { get; }

        public string UpdatedBy { get; }

        public DateTime UpdatedOn { get; }
        
        public Post(int id, string title, string[] category, string author, 
            bool isPublished, DateTime publishedDate, string updatedBy, DateTime updatedOn)
        {
            Id = id;
            Title = title;
            Category = category;
            Author = author;
            IsPublished = isPublished;
            PublishedDate = publishedDate;
            UpdatedBy = updatedBy;
            UpdatedOn = updatedOn;
        }
    }
}
