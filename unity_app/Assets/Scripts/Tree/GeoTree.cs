/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            GeoTree
// * Author:           Drew Weber
// * Description:      Used as a structure to allow for insertion into MongoDB
// ! Important note:   Id is auto generated by the database upon insertion of data
// *                     
/////////////////////////////////////////////////////////////////////////////////////

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

public class GeoTree
    {
        public GeoTree(string _name,string _species,GeoJsonPoint<GeoJson2DGeographicCoordinates> _location)
        {
            name = _name;
            species = _species;
            Location = _location;
        }
        [BsonId]
        public ObjectId Id { get; set; } //ID is auto generated by the database
        public string name { get; set; }
        public string species { get; set; }
        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location { get; set; }
    }