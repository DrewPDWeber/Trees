using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeFactory : Singleton<TreeFactory>
{
    [SerializeField] private Tree[] availableTrees;
    [SerializeField] private Player player;
    [SerializeField] private float waitTime = 180.0f;
    [SerializeField] private int startingTrees = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 50.0f;
    
    JsonHelper jsonHelper = new JsonHelper();

    private void Awake()
    {
        Assert.IsNotNull(availableTrees);
        Assert.IsNotNull(player);
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < startingTrees; i++)
        {
            InstantiateTree();
        }
        StartCoroutine(GenerateTrees());
    }

    private IEnumerator GenerateTrees()
    {
        while (true)
        {
            InstantiateTree();
            yield return new WaitForSeconds(waitTime);
        }
    }

    private void InstantiateTree()
    {
       
        int index = Random.Range(0, availableTrees.Length);
        float x = player.transform.position.x + GenerateRange();
        float z = player.transform.position.z + GenerateRange();
        float y = player.transform.position.y;

        availableTrees[index].TreeInfo = (jsonHelper.CreateTree(index, "A lovely Tree", "Potato", new GeoTypeInfo(1, new GeoPosition(x, z))));

        Instantiate(availableTrees[index], new Vector3((float)availableTrees[index].TreeInfo.GeoType.GeoLocation.Longitude, y, (float)availableTrees[index].TreeInfo.GeoType.GeoLocation.Latitude), Quaternion.identity);

    }

    private float GenerateRange()
    {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }
}
