using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public GameObject Spawn;
    public GameObject Player;
    public string colenam;

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            Player.transform.position = Spawn.transform.position;
            Player.transform.rotation = Spawn.transform.rotation;
        }
    }
}
