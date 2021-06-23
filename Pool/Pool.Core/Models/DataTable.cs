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
        public string Fecha { get; set; }

        [BsonElement("Temp_min_register")]
        public decimal Temp_min_register { get; set; }

        [BsonElement("temp_max_register")]
        public decimal Temp_max_register { get; set; }
        [BsonElement("Ph_min_register")]
        public decimal Ph_min_register { get; set; }
        [BsonElement("ph_max_register")]
        public decimal Ph_max_register { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string IdUser { get; set; }
    }
}