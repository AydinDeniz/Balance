﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsuzGameOver : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag==("object"))
        {
            Debug.Log("GAME OVER");
        }
    }




}
