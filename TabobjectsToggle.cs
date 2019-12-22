using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabobjectsToggle : MonoBehaviour {

    public GameObject Toggler;
    public bool open=false;
    
    

    void FixedUpdate ()
    {
        
	if (open==false)
        {
            if (transform.position.y - Camera.main.transform.position.y > 5.82)
            {
                open = true;
                this.enabled = false;
            }
            else
            {
                this.transform.position = new Vector2(0, this.transform.position.y + 0.15f);
            }
        }

        if (open == true)
        {
            if (transform.position.y - Camera.main.transform.position.y < 4.4)
            {
                open = false;
                this.enabled = false;
            }
            else
            {
                this.transform.position = new Vector2(0, this.transform.position.y - 0.15f);
            }
        }
        }
}
