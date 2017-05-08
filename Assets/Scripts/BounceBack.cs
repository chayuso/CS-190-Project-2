using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBack : MonoBehaviour {
    private PlayerControl PlayerController;
    public string colenam;
    // Use this for initialization
    void Start () {
        PlayerController = GameObject.Find("Movement").GetComponent<PlayerControl>();

    }

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            PlayerController.P1RB.AddRelativeForce(-transform.forward * 5.0f, ForceMode.Impulse);
            PlayerController.P1RB.AddRelativeForce(-transform.up * 2.0f, ForceMode.Impulse);

        }
    }
}
