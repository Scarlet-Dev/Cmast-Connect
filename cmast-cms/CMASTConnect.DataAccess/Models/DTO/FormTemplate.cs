using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Models.DTO
{
    /// <summary>
    /// Basic Form Template Model. Will be stored in MongoDB
    /// </summary>
    public class FormTemplate
    {
        [BsonId, BsonRequired]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string FormName { get; set; }

        [BsonRepresentation(BsonType.Array)]
        public string[] FormData { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedOn { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string CreatedBy { get; set; }
        
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime LastUpdatedOn { get; set; }

        [BsonDateTimeOptions(DateOnly = false, 
            Kind =DateTimeKind.Utc, 
            Representation = BsonType.DateTime)]
        public string LastUpdatedBy { get; set; }
    }
}
