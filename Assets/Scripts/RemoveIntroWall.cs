using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveIntroWall : MonoBehaviour {
    public string colenam;
    public GameObject InvisWall;

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            InvisWall.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
