using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLoadLevel : MonoBehaviour {
    public int levelindex;
    SpriteRenderer rend;
    bool clicked = false;
    public float delay_before_load;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    IEnumerator Wait()
    {
        rend.enabled = false;
        yield return new WaitForSeconds(delay_before_load);
        Application.LoadLevel(levelindex);
    }

    void OnMouseDown()
    {
        if(clicked==false)
        {
            clicked = true;
            StartCoroutine(Wait());
        }
    }
}
