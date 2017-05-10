using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlatform : MonoBehaviour {
    public string colenam;
    public GameObject Player;
    public GameObject TopBlockPrefab;
    public GameObject TopBlockSpawn;
    private bool inWater = false;
    void FixedUpdate()
    {
        if (inWater)
        {
            Player.GetComponent<Rigidbody>().AddRelativeForce(transform.up * 0.1f, ForceMode.Impulse);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            inWater = true;
        }
        if (colenam.Length >= 14)
        {
            if (colenam.Substring(0, 14) == "TopMovingBlock")
            {
                col.gameObject.GetComponent<CustomTrigger>().Hit();
                Destroy(col.gameObject);
                spawnTopMovingBlock(TopBlockSpawn);
            }
        }
        
    }
    void OnTriggerExit(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            inWater = false;
        }

    }
    void spawnTopMovingBlock(GameObject spawn)
    {
            GameObject.Instantiate(
            TopBlockPrefab,
            spawn.transform.position,
            spawn.transform.rotation);
    }
}
