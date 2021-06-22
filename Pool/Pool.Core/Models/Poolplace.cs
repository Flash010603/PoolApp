using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Pool.Core.Models
{
    public class Poolplace
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get;set;}
        [BsonElement("name_pool")]
        public string Name_Pool { get; set; }
        [BsonElement("location")]
        public string Location { get; set; }
        [BsonElement("temp_min")]
        public decimal Temp_min { get; set; }
        [BsonElement("temp_max")]
        public decimal Temp_max { get; set; }
        [BsonElement("temp_current")]
        public decimal Temp_current { get; set; }

        [BsonElement("ph_min")]
        public decimal Ph_min { get; set; }
        [BsonElement("ph_max")]
        public decimal Ph_max { get; set; }
        [BsonElement("ph_current")]
        public decimal Ph_current { get; set; }

        [BsonElement("grados")]
        public string Grados { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string IdUser { get; set; }

        public Poolplace()
        {
            this.Grados = "c";
        }
    }
}