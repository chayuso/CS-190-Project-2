using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameState : MonoBehaviour {
    public bool canJump = true;
    public bool jumpThroughPlat = true;
    public PlayerControl MovementController;
    public int CollectedItems = 0;
    public bool underwater = false;
    public bool collectedAll = false;
    public Text Counter;
    //public GameObject Friend1;
    //public GameObject Friend2;
    //public GameObject Friend3;
    public GameObject Friends;
    void FixedUpdate()
    {
        MovementController.ASM1.SetBool("InAir",!canJump);
        Counter.text = CollectedItems.ToString() + "/25";
        collectedAll = (CollectedItems > 24);
        if (collectedAll)
        {
            //Friend1.GetComponent<MeshRenderer>().enabled = true;
            //Friend2.GetComponent<MeshRenderer>().enabled = true;
            //Friend3.GetComponent<MeshRenderer>().enabled = true;
            Friends.SetActive(true);
        }
    }
}
