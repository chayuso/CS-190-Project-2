using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFloorBlock : MonoBehaviour {


    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(-transform.forward * 1.0f, ForceMode.Impulse);

    }
}
