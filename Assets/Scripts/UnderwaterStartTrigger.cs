using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterStartTrigger : MonoBehaviour {
    public string colenam;
    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            gameObject.GetComponent<CustomTrigger>().Hit();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
