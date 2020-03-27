using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class display_get_tree_data : MonoBehaviour // remove monobehaviour to make whole script static
{
    public Text tree_data;
    public Text Id;
    public Text Name;
    public Text Species;

    // Start is called before the first frame update
    void Start()
    {
        tree_data.text = Tree.treeDesc;
        Id.text = Tree.stat_id;
        Name.text = Tree.stat_name;
        Species.text = Tree.stat_species;
}

    // Update is called once per frame
    // void Update()
    // {

     //}
}