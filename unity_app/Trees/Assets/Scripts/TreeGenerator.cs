using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeGenerator : Singleton<TreeGenerator>
{
    [SerializeField] 
    private Tree[] closeTrees;
    [SerializeField] 
    private Player player;

    const int MAX_RANGE = 10;
    const string USERNAME = "Unity";
    const string PASSWORD = "5OR1ALs0wp1JGWSa";
    const string DATABASE = "Trees";
    const string COLLECTION = "Tree_Info";
    MongoDBManager dbManager;
    private void Awake()
    {
        Assert.IsNotNull(closeTrees);
        Assert.IsNotNull(player);
    }
    
    void Start()
    {
        dbManager = new MongoDBManager(USERNAME,PASSWORD,DATABASE,COLLECTION);
        getClosestTrees(50.671255, -120.364383);
    }
    void getClosestTrees(double Longitude,double Latitude)
    {
        List<GeoTree> geoTrees = dbManager.GetEntrys(Longitude,Latitude);
        Debug.Log("Trees retreaved");
        for(int i=0;i<closeTrees.Length;i++)
        {
            InstantiateTree(i,geoTrees[i].Id,geoTrees[i].Location,geoTrees[i].name,geoTrees[i].species);
        }
        Debug.Log("Trees instantiated");
    }
    private void InstantiateTree(int index, ObjectId id,GeoJsonPoint<GeoJson2DGeographicCoordinates> location,string name,string species)
    {
        //closeTrees[index].Id = id;
        closeTrees[index].Location = location;
        closeTrees[index].Name = name;
        closeTrees[index].Species =  species;
        Instantiate(closeTrees[index], new Vector3((float)closeTrees[index].Location.Coordinates.Longitude, player.transform.position.y, (float)closeTrees[index].Location.Coordinates.Latitude), Quaternion.identity);    
    }
}