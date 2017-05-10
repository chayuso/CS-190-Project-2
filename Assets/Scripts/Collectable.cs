using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
    public string colenam;
    public GameState GameState;
    void Start()
    {
        GameState = GameObject.Find("GameState").GetComponent<GameState>();
    }
    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<Light>().enabled = false;
            GameState.CollectedItems++;
            gameObject.GetComponent<CustomTrigger>().Hit();
        }
    }
}
