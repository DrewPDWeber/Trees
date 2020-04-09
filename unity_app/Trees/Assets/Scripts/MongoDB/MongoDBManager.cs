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
    private IMongoCollection < GeoTree > collection;
    #endregion


    public MongoDBManager(string user, string pass, string database) {
        username = user;
        password = pass;
        databaseName = database;


        Debug.Log("Attempting to connect to database...");
        mongoClient = new MongoClient(SERVER_BASE_STRING + user + ":" + password + SERVER_SETTINGS_STRING);
        mongoDatabase = mongoClient.GetDatabase(databaseName);

    }

    public void AddEntry(GeoTree entry) => collection.InsertOne(entry);

    public List < GeoTree > GetEntrys(double latitude, double longitude) // Gets the 10 closest entrys
    {
        var point = GeoJson.Point(GeoJson.Geographic(latitude, longitude));
        var locationQuery = new FilterDefinitionBuilder < GeoTree > ().Near(tag => tag.Location, point, 50); //fetch results that are within a 50 metre radius of the point we're searching.
        var query = collection.Find(locationQuery).Limit(10); //Limit the query to return only the top 10 results.
        return query.ToList();
    }

    public GeoTree GetEntry(double latitude, double longitude) // Gets closest entrys
    {
        var point = GeoJson.Point(GeoJson.Geographic(latitude, longitude));
        var locationQuery = new FilterDefinitionBuilder < GeoTree > ().Near(tag => tag.Location, point, 50); //fetch results that are within a 50 metre radius of the point we're searching.
        var query = collection.Find(locationQuery).Limit(1); //Limit the query to return only the top 10 results.
        return query.FirstOrDefault();
    }

}