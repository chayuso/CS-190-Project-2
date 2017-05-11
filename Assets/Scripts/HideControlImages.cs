using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HideControlImages : MonoBehaviour {
    public GameObject Img1;
    public GameObject Img2;
    public string colenam;

    void OnTriggerEnter(Collider col)
    {
        colenam = col.name;
        if (colenam == "Base")
        {
            Img1.SetActive(false);
            Img2.SetActive(false);
        }
    }
}
