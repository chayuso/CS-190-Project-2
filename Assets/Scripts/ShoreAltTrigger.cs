using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoreAltTrigger : MonoBehaviour {
    public GameObject AlternateTrigger;
    public string colenam;
    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            AlternateTrigger.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
