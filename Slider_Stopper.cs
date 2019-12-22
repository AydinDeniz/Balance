using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_Stopper : MonoBehaviour
{

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Stopper")
        {
            Debug.Log("eben");

        }
    }
}
