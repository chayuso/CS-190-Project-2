using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(-transform.forward * 50.0f, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update () {
        //gameObject.GetComponent<Rigidbody>().AddRelativeForce(-transform.forward * 0.1f, ForceMode.Impulse);

    }
}
