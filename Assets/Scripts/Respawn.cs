using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
    public GameObject Placement1;
    public GameObject Placement2;
    public GameObject Placement3;
    public GameObject Spawn;
    public GameObject Player;
    public string colenam;
    public GameObject BlockPrefab;
    public GameObject BlockSpawn;

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            Player.transform.position = Spawn.transform.position;
            Player.transform.rotation = Spawn.transform.rotation;

            Platform1.transform.position = Placement1.transform.position;
            Platform2.transform.position = Placement2.transform.position;
            Platform3.transform.position = Placement3.transform.position;
            Platform1.transform.rotation = Placement1.transform.rotation;
            Platform2.transform.rotation = Placement2.transform.rotation;
            Platform3.transform.rotation = Placement3.transform.rotation;
        }
        if (colenam.Length >=11)
        {
            if (colenam.Substring(0, 11) == "MovingBlock")
            {
                Destroy(col.gameObject);
                spawnMovingBlock(BlockSpawn);
            }
        }    
    }
    void spawnMovingBlock(GameObject spawn)
    {
        var movingBlock = (GameObject)Instantiate(
            BlockPrefab,
            spawn.transform.position,
            spawn.transform.rotation);
    }
}
