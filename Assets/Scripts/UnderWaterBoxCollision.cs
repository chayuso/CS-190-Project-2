using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderWaterBoxCollision : MonoBehaviour {
    public string colname;
    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        colname = col.gameObject.name;
        if (colname == "Base")
        {
            gameObject.GetComponent<CustomTrigger>().Hit();
        }
    }
}
