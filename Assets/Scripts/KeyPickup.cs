using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour {
    public GameObject Door;
    public GameObject Key;
    public string colenam;
    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            Door.GetComponent<MeshRenderer>().enabled=false;
            Door.GetComponent<BoxCollider>().enabled = false;
            Key.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<CustomTrigger>().Hit();
        }
    }
}
