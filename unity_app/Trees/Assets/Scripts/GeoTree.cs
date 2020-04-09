using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

public class GeoTree
    {
        public GeoTree(string aname,string spec,GeoJsonPoint<GeoJson2DGeographicCoordinates> loc)
        {
            name = aname;
            species = spec;
            Location = loc;
        }
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string species { get; set; }
        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location { get; set; }
    }