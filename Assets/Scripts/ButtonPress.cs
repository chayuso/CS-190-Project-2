using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {
    public GameObject BlockerPrefab;
    public GameObject BlockerSpawn;
    public GameObject Bridge;
    public string colenam;
    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Bridge.GetComponent<MeshRenderer>().enabled = true;
            Bridge.GetComponent<BoxCollider>().enabled = true;
            spawnBlockerBlock(BlockerSpawn);
        }
    }
    void spawnBlockerBlock(GameObject spawn)
    {
        var movingBlock = (GameObject)Instantiate(
            BlockerPrefab,
            spawn.transform.position,
            spawn.transform.rotation);
    }
}
