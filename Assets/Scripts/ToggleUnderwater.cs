using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUnderwater : MonoBehaviour {
    public bool ToggleValue = false;
    public string colenam;
    private GameState GameState;
    // Use this for initialization
    void Start () {
        GameState = GameObject.Find("GameState").GetComponent<GameState>();

    }

    // Update is called once per frame
    void OnTriggerEnter (Collider col) {
        colenam = col.name;
        if (colenam == "Base")
        {
            GameState.underwater = ToggleValue;
        }
    }
}
