using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.Models.DTO
{
    /// <summary>
    /// Basic Form Model. Will be stored in MongoDB
    /// </summary>
    public class Form
    {
        
        public int Id { get; set; }

        public string FormName { get; set; }

        public string[] FormData { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }
        
        public DateTime LastUpdatedOn { get; set; }

        public string LastUpdatedBy { get; set; }
    }
}
