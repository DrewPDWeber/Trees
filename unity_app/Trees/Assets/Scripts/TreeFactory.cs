using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver.GeoJsonObjectModel;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeFactory : Singleton<TreeFactory>
{
    [SerializeField] private Tree[] closestTrees;
    [SerializeField] private Player player;

    const int MIN_RANGE = 10;
    const int MAX_RANGE = 180;

    private void Awake()
    {
        Assert.IsNotNull(closestTrees);
        Assert.IsNotNull(player);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < closestTrees.Length; i++)
        {
            float latitude = player.transform.position.x + GenerateRange();     // testing data
            float longtitude = player.transform.position.z + GenerateRange();   // testing data-
            InstantiateTree(i, latitude, longtitude);    
        }
    }

    private void InstantiateTree(int index, float latitude, float longitude)
    {
        /*
        Debug.Log(Input.location.lastData.latitude);
        Debug.Log(y);
        Debug.Log(z);
        */
        string treeName = TreeTypes.TreeSpecies[Random.Range(0, TreeTypes.TreeSpecies.Count)];
        string treeSpecies = TreeTypes.TreeNames[Random.Range(0, TreeTypes.TreeNames.Count)];
        GeoJsonPoint<GeoJson2DGeographicCoordinates> treeLocation = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(latitude,longitude));  

        closestTrees[index].Name= treeName;
        closestTrees[index].Species = treeSpecies;
        closestTrees[index].Location = treeLocation;

        Debug.Log("Tree Name added:" + closestTrees[index].Name);
        Instantiate(closestTrees[index], new Vector3(latitude, player.transform.position.y, longitude), Quaternion.identity);    
    }

    private float GenerateRange()
    {
        return Random.Range(MIN_RANGE, MAX_RANGE);
    }
}