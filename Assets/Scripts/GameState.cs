using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    public bool canJump = true;
    public bool jumpThroughPlat = true;
    public PlayerControl MovementController;
    public int CollectedItems = 0;
    public bool underwater = false;
    void FixedUpdate()
    {
        MovementController.ASM1.SetBool("InAir",!canJump);
    }
}
