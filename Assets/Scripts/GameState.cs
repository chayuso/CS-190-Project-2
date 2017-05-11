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
    public Text Counter;
    void FixedUpdate()
    {
        MovementController.ASM1.SetBool("InAir",!canJump);
        Counter.text = CollectedItems.ToString() + "/25";
    }
}
