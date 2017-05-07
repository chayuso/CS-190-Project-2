using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpablePlatforms : MonoBehaviour {
    private GameState GameState;
    private bool lastCheck;
	// Use this for initialization
	void Start () {
        GameState = GameObject.Find("GameState").GetComponent<GameState>();
        lastCheck = GameState.jumpThroughPlat;
    }
	
	// Update is called once per frame
	void Update () {
        if (lastCheck != GameState.jumpThroughPlat)
        {
            lastCheck = GameState.jumpThroughPlat;
            gameObject.GetComponent<BoxCollider>().enabled = !lastCheck;

        }
        else { lastCheck = GameState.jumpThroughPlat; }
    }
}
