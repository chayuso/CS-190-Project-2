using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {
    public Animator ASM1;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        ASM1.SetBool("Ending",true);
        GameObject.Find("Movement").GetComponent<PlayerControl>().enabled=false;

    }
}
