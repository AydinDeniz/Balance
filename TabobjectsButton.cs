using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabobjectsButton : MonoBehaviour {

    
    public GameObject Whatdoitoggle;

    void OnMouseDown()
    {
        
            TabobjectsToggle kod = Whatdoitoggle.GetComponent<TabobjectsToggle>();
            kod.enabled=true;
       
    }
}
