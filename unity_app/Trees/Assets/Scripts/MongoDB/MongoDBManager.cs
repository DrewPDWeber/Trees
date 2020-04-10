///////////////////////////////////////////////////////////////////////////////
//                   
// Title:            MongoDBManager
//
// Author:           Drew Weber
// Description :     Used to connect to MongoDB server, allows insertion of entries 
//                   retreaval of entries near a point(location)    
//
///////////////////////////////////////////////////////////////////////////////

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

public class MongoDBManager{
    #region Const Data
    private
    const string SERVER_BASE_STRING = "mongodb+srv://"; //Username and password will be added to the end of this
    private
    const string SERVER_SETTINGS_STRING = "@treefriends-urqb0.mongodb.net/test?retryWrites=true"; //The server location
    #endregion

    #region Private Variables
    private string databaseName;
    private string username;
    private string password;


    //The MongoPlugin 
    private MongoClient mongoClient;
    private IMongoDatabase mongoDatabase;
    private IMongoCollection < GeoTree > mongoCollection;
    #endregion

    #region Functions
    public MongoDBManager(string user, string pass, string database,string collection) 
    {
        username = user;
        password = pass;
        databaseName = database;


        Debug.Log("Attempting to connect to database...");
        mongoClient = new MongoClient(SERVER_BASE_STRING + user + ":" + password + SERVER_SETTINGS_STRING);
        mongoDatabase = mongoClient.GetDatabase(databaseName);
        mongoCollection = mongoDatabase.GetCollection<GeoTree>(collection);

        //IMPORTANT
        //Needed in order to be able to use near, tells the server that Location will be used as the index key
        mongoCollection.Indexes.CreateOne(Builders<GeoTree>.IndexKeys.Geo2DSphere("Location"));

    }

    public void AddEntry(GeoTree entry) => mongoCollection.InsertOne(entry);

    public List < GeoTree > GetEntrys(double longitude,double latitude) // Gets the 10 closest entrys
    {
        var point = GeoJson.Point(GeoJson.Geographic(longitude,latitude));
        var locationQuery = new FilterDefinitionBuilder < GeoTree > ().Near(tag => tag.Location, point, 50); //fetch results that are within a 50 metre radius of the point we're searching.
        var query = mongoCollection.Find(locationQuery).Limit(10); //Limit the query to return only the top 10 results.
        return query.ToList();
    }

    public GeoTree GetEntry(double longitude,double latitude) // Gets closest entrys
    {
        var point = GeoJson.Point(GeoJson.Geographic(longitude,latitude));
        var locationQuery = new FilterDefinitionBuilder < GeoTree > ().Near(tag => tag.Location, point, 50); //fetch results that are within a 50 metre radius of the point we're searching.
        var query = mongoCollection.Find(locationQuery).Limit(1); //Limit the query to return only the top 10 results.
        return query.FirstOrDefault();
    }
    #endregion
}