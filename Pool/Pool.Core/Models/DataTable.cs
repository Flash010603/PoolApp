using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Pool.Core.Models
{
    public class DataTable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("fecha")]
        public decimal Fecha { get; set; }

        [BsonElement("Temp_min")]
        public decimal Temp_min { get; set; }

        [BsonElement("temp_max")]
        public decimal Temp_max { get; set; }
        [BsonElement("Ph_min")]
        public decimal Ph_min { get; set; }
        [BsonElement("ph_max")]
        public decimal Ph_max { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string IdUser { get; set; }
    }
}