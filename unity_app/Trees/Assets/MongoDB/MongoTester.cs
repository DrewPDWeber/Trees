using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

public class MongoTester : MonoBehaviour
{
    private const string SERVER_URL = "mongodb+srv://drew:RpGFhvV3EZr226@treefriends-urqb0.mongodb.net/test?authSource=admin&replicaSet=TreeFriends-shard-0&readPreference=primary&appname=Unity&ssl=true";
    private const string DATABASE = "Trees";

    private MongoClient mongoClient;
    private IMongoDatabase  mongoDatabase;
    private IMongoCollection<Entity> treeCollection;

    private IMongoCollection<BsonDocument> documentCollection;
    public void Start() 
    {
        Debug.Log("START");
        mongoClient = new MongoClient(SERVER_URL);
        mongoDatabase = mongoClient.GetDatabase(DATABASE);
        treeCollection = mongoDatabase.GetCollection<Entity>("Tree_Info");
        documentCollection = mongoDatabase.GetCollection<BsonDocument>("Tree_Info");
        string name = TreeTypes.TreeNames[Random.Range(0, TreeTypes.TreeNames.Count)];
        string species = TreeTypes.TreeSpecies[Random.Range(0, TreeTypes.TreeSpecies.Count)];

        double latitude = 90;
        double longitude = 90;

    
        Entity tree = new Entity();
        tree.name = name;
        tree.species = species;
        tree.Location = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(latitude,longitude));

        AddEntry(tree);

        //AddEntry(name,species,latitude,longitude);
        Debug.Log("ADDED new tree");

        Entity found = GetEntry(latitude,longitude);
        Debug.Log("FOUND:" + found.name + " " + found.Location);

        Debug.Log("GET TEST");
    }

    public class Entity
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string species { get; set; }
        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location { get; set; }
    }

    public void AddEntry(Entity doc)
    {
        treeCollection.InsertOne(doc);
    }

    public void AddEntry(string name,string species,double latitude,double longitude)
    {

       //treeCollection.Indexes.CreateOne(Builders<BsonDocument>.IndexKeys.Geo2DSphere("Location"));
        var document = new BsonDocument
        {
            { "name", name},
            { "species", species },
            { "location", GeoJson.Point(new GeoJson2DCoordinates(latitude,longitude)).ToBsonDocument() } 
        };
        documentCollection.InsertOne(document);
    }

    public Entity GetEntry(double latitude,double longitude)
    {

        /*
        var geoNearOptions = new BsonDocument {
            { "near", new BsonDocument {
                { "type", "Point" }, 
                { "coordinates", new BsonArray {99,99} },
                } },
            { "distanceField", "dist.calculated" },
            { "maxDistance", 100 }, 
            { "includeLocs", "dist.location" },   
            { "spherical" , true }
        };

        var projectOptions = new BsonDocument {
            { "_id" , 1 }, 
            { "place_id", 1 }, 
            { "name" , 1 }, 
            { "dist", 1}
        };
        var points = new List<BsonDocument>();
        points.Add( new BsonDocument { {"$geoNear", geoNearOptions} });
        //points.Add( new BsonDocument { {"$project", projectOptions} });

        using(var cursor = treeCollection.Aggregate<BsonDocument>(points)) {
            while(cursor.MoveNext()) {
                foreach (var doc in cursor.Current) 
                {
                    Debug.Log(doc);
                }
            }
        } 
        */
      
       var point = GeoJson.Point(GeoJson.Geographic(latitude, longitude));
        var locationQuery = new FilterDefinitionBuilder<Entity>().Near(tag => tag.Location, point,50); //fetch results that are within a 50 metre radius of the point we're searching.
        var query = treeCollection.Find(locationQuery).Limit(10); //Limit the query to return only the top 10 results.
        return query.FirstOrDefault();

    }

}

