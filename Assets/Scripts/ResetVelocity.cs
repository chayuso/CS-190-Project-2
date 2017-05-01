using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVelocity : MonoBehaviour {
    public GameObject Movement;
    void OnCollisionEnter()
    {
        Movement.GetComponent<PlayerControl>().P1RB.velocity = Vector3.zero;
    }
}
