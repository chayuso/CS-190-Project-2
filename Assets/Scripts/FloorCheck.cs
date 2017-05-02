using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour {
    public GameState GS;
    public PlayerControl MovementController;
    public string check = "None";
    void OnTriggerEnter(Collider colName)
    {
        check = colName.name;
        GS.canJump = true;
    }
}
