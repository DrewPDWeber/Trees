using System.Collections;
using System.Collections.Generic;
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
            float longtitude = player.transform.position.z + GenerateRange();   // testing data
            // float latitude = (float)closestTrees[i].Collection.Location.Latitude;
            // float longtitude = (float)closestTrees[i].Collection.Location.Longitude;
            InstantiateTree(i, latitude, longtitude);    
        }
    }

    private void InstantiateTree(int index, float latitude, float longtitude)
    {
        /*
        Debug.Log(Input.location.lastData.latitude);
        Debug.Log(y);
        Debug.Log(z);
        */
        string treeName = TreeTypes.TreeSpecies[Random.Range(0, TreeTypes.TreeSpecies.Count)];
        string treeSpecies = TreeTypes.TreeNames[Random.Range(0, TreeTypes.TreeNames.Count)];
        GeoJsonCollection treeGeo = new GeoJsonCollection(1, new GeoJsonPosition(latitude, longtitude));     

        closestTrees[index].Id = index;
        closestTrees[index].Name = treeName;
        closestTrees[index].Species = treeSpecies;
        closestTrees[index].Collection = treeGeo;

        Instantiate(closestTrees[index], new Vector3(latitude, player.transform.position.y, longtitude), Quaternion.identity);    
    }

    private float GenerateRange()
    {
        return Random.Range(MIN_RANGE, MAX_RANGE);
    }
}