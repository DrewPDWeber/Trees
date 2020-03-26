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
        /*
        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        */
        for (int i = 0; i < closestTrees.Length; i++)
        {
            InstantiateTree(i, 50.671255 + 0.000001 * i, -120.364383 + 0.000001 * i);   // I don't have real data right now. So I just use the coordinate of TRU campus. -- by Rui
        }
    }

    private void InstantiateTree(int index, double latitude, double longtitude) // adding latitude and longtitude as two parameters. -- by Rui
    {
        float x = player.transform.position.x + GenerateRange();
        float z = player.transform.position.z + GenerateRange();
        float y = player.transform.position.y;
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

        Instantiate(closestTrees[index], 
            new Vector3((float)closestTrees[index].Collection.Location.Longitude, 
            y, 
            (float)closestTrees[index].Collection.Location.Latitude), 
            Quaternion.identity);

    }

    private float GenerateRange()
    {
        return Random.Range(MIN_RANGE, MAX_RANGE);
    }
}