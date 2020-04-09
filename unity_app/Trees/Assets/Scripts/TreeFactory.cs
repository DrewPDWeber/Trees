using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeFactory : Singleton<TreeFactory>
{
    [SerializeField] private Tree[] closestTrees;
    [SerializeField] private Player player;

    const int MIN_RANGE = -90;
    const int MAX_RANGE = 90;

    const string USERNAME = "Unity";
    const string PASSWORD = "5OR1ALs0wp1JGWSa";
    const string DATABASE = "Trees";
    const string COLLECTION = "Tree_Info";

    MongoDBManager dbManager;
    private void Awake()
    {
        Assert.IsNotNull(closestTrees);
        Assert.IsNotNull(player);
    }

    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("STARTED");


        double longitude = 60.1918800004297;
        double latitude = 24.9685821991864;

        Debug.Log(longitude);
        Debug.Log(latitude);
        dbManager = new MongoDBManager(USERNAME,PASSWORD,DATABASE,COLLECTION);

        // Adds trees
        /*
        for(int i=0;i<10;i++)
        {
            AddRandomTree(longitude+Random.Range(-.00000001f, .00000001f),latitude+Random.Range(-.00000001f, .00000001f));
        }
        */

        /* Gets closest tree
        GeoTree geoTree = dbManager.GetEntry(longitude,latitude); // gets the closest trees
        InstantiateTree(0, geoTree);
        Debug.Log(geoTree.Id);

        */
        
        List<GeoTree> geoTrees = dbManager.GetEntrys(longitude,latitude); // gets the closest trees

        for (int i = 0; i < closestTrees.Length; i++)
        {
            InstantiateTree(i, geoTrees[i]);
            Debug.Log("FOUND A TREE!!! " + "ID:" + geoTrees[i].Id.ToString() + " Name:" + geoTrees[i].name + " Species" + geoTrees[i].species + " Location" + geoTrees[i].Location.Coordinates.Longitude.ToString()+"," + geoTrees[i].Location.Coordinates.Latitude.ToString());
        }
        
        
    }

    private void InstantiateTree(int index, GeoTree geoTree)
    {
 
        string treeName = TreeTypes.TreeSpecies[Random.Range(0, TreeTypes.TreeSpecies.Count)];
        string treeSpecies = TreeTypes.TreeNames[Random.Range(0, TreeTypes.TreeNames.Count)];
        GeoJsonPoint<GeoJson2DGeographicCoordinates> treeLocation = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(geoTree.Location.Coordinates.Longitude,geoTree.Location.Coordinates.Latitude));  

        closestTrees[index].Name= treeName;
        closestTrees[index].Species = treeSpecies;
        closestTrees[index].Location = treeLocation;

        Debug.Log("Tree Name added:" + closestTrees[index].Name + " added to database");
        Instantiate(closestTrees[index], new Vector3((float)treeLocation.Coordinates.Longitude, player.transform.position.y, (float)treeLocation.Coordinates.Latitude), Quaternion.identity);    
    }
    //Generates a random tree and inserts into database
    private void AddRandomTree(double  longitude,double latitude)
    {
        string treeName = TreeTypes.TreeSpecies[Random.Range(0, TreeTypes.TreeSpecies.Count)];
        string treeSpecies = TreeTypes.TreeNames[Random.Range(0, TreeTypes.TreeNames.Count)];
        GeoJsonPoint<GeoJson2DGeographicCoordinates> treeLocation = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(longitude,latitude));  

         //adds tree to database
        GeoTree geoTree = new GeoTree(treeName,treeSpecies,treeLocation);
        dbManager.AddEntry(geoTree);
    }

    private float GenerateRange()
    {
        return Random.Range(MIN_RANGE, MAX_RANGE);
    }
}