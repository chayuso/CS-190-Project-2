using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {
    public string namee = "None";
    void OnCollisionEnter(Collision col)
    {
        namee = col.gameObject.name;
    }
}
