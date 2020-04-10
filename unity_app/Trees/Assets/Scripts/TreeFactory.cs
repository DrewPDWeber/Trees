///////////////////////////////////////////////////////////////////////////////
//                   
// Title:            TreeFactory
//
// Authors:          Drew Weber, Rui Wang
// Description:      Used to populate the map with tree assets, connect to the 
//                   database in order to retreave tree imformation, and creates
//                   random tree imforamtion for testing purposes
//                       
//
///////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeFactory : Singleton<TreeFactory>
{
    [SerializeField] private Tree[] closestTrees;
    [SerializeField] private Player player;

    #region MongoDB
    const string USERNAME = "Unity";
    const string PASSWORD = "5OR1ALs0wp1JGWSa";
    const string DATABASE = "Trees";
    const string COLLECTION = "Tree_Info";

    MongoDBManager dbManager;

    #endregion
    private void Awake()
    {
        Assert.IsNotNull(closestTrees);
        Assert.IsNotNull(player);
    }

    // Start is called before the first frame update
    void Start()
    {   
        double longitude = 60.1918800004297;
        double latitude = 24.9685821991864;

        //Connect to database and collection
        dbManager = new MongoDBManager(USERNAME,PASSWORD,DATABASE,COLLECTION);

        // Adds trees to database
        /*
        for(int i=0;i<10;i++)
        {
            AddRandomTree(longitude+Random.Range(-.000001f, .000001f),latitude+Random.Range(-.000001f, .000001f));
        }
        */

         //Gets closest tree
         /*
        GeoTree geoTree = dbManager.GetEntry(longitude,latitude); // gets the closest trees
        InstantiateTree(0, geoTree);
        Debug.Log(geoTree.Id);
        */
        
        
        List<GeoTree> geoTrees = dbManager.GetEntrys(longitude,latitude); // gets the 10 closest trees
        for (int i = 0; i < closestTrees.Length; i++)
        {
            InstantiateTree(i, geoTrees[i]);
            //Debug.Log("FOUND A TREE!!! " + "ID:" + geoTrees[i].Id.ToString() + " Name:" + geoTrees[i].name + " Species" + geoTrees[i].species + " Location" + geoTrees[i].Location.Coordinates.Longitude.ToString()+"," + geoTrees[i].Location.Coordinates.Latitude.ToString());
        }
        
        
    }

    private void InstantiateTree(int index, GeoTree geoTree)
    {
        //Debug.Log("Instantiating Tree " + index);
        closestTrees[index].Name= geoTree.name;
        closestTrees[index].Species = geoTree.species;
        closestTrees[index].Location = geoTree.Location;

        Instantiate(closestTrees[index], new Vector3((float)geoTree.Location.Coordinates.Longitude, player.transform.position.y, (float)geoTree.Location.Coordinates.Latitude), Quaternion.identity);    
        //Debug.Log("Instantiated Tree " + index);
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
}