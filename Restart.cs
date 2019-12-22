using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    private void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
