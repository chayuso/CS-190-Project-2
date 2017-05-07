using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    public bool canJump = true;
    public bool jumpThroughPlat = true;
    public PlayerControl MovementController;
    void FixedUpdate()
    {
        MovementController.ASM1.SetBool("InAir",!canJump);
    }
}
