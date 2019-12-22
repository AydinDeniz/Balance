using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuObject_sonsuz : MonoBehaviour
{
    
    public GameObject slider;
    Vector2 mouseB = new Vector2(0, -90);
    
    GameObject[] objects;
    public GameObject realobject;


    private void Start()
    {
        slider = GameObject.FindGameObjectWithTag("slider");
    }



    void OnMouseDown()
    {

        
        Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mouseB = Camera.main.ScreenToWorldPoint(mouse); ;

    }

    void OnMouseUp()
    {
        mouseB = new Vector2(0, -90);
    }

    void Update()
    {
        Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mouse = Camera.main.ScreenToWorldPoint(mouse); ;
        float yfark = mouseB.y - mouse.y;
        if (yfark > 0.9 && Mathf.Abs(mouseB.x - mouse.x) < yfark * 1.2)
        {

            GameObject filling = GameObject.FindGameObjectWithTag("MenuFrame");
            filling.GetComponent<TabobjectsToggle>().enabled = true;
            GameObject createdobje = Instantiate(realobject, mouse, Quaternion.identity);
            createdobje.GetComponent<MousedragandR>().active = true;
            slider.GetComponent<ipedizsonsuz>().Genrandom(transform.position);

            GameObject.Destroy(this.gameObject);

        }
    }

}

