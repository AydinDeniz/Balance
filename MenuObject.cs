using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuObject : MonoBehaviour
{
    public int sayi;
    public GameObject slider;
    Vector2 mouseB= new Vector2(0,-90);
    public int sira=-1;
    
    public GameObject realobject;
    public float ekrangenisligi;

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(0.3f);
        GameObject slidercik = GameObject.FindGameObjectWithTag("slider");
        slidercik.transform.position = new Vector2(0, slidercik.transform.position.y);
        yield return new WaitForSeconds(0.2f);

        transform.position = new Vector2((sira-0.5f) * ekrangenisligi / 5, this.transform.position.y);
    }

    private void Start()
    {
       


        foreach (GameObject obje in GameObject.FindGameObjectsWithTag("icon"))
        {
            if (obje.transform.position.x < transform.position.x)
            {
                sira++;
            }
        }

    }

    public void Sirala(int yokolansira)
    {
        StartCoroutine(Wait());
        sira = -1;


        foreach (GameObject obje in GameObject.FindGameObjectsWithTag("icon"))
        {
            if (obje.transform.position.x < transform.position.x)
            {
                sira++;
            }
        }
        if(sira>yokolansira)
        {
            sira--;
        }
    }

    void OnMouseDown ()
    {
        
            slider.GetComponent<ipediz>().activeM = true;
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
        if (yfark>0.9 && Mathf.Abs(mouseB.x-mouse.x)<yfark*1.2)
        {
            
            GameObject filling = GameObject.FindGameObjectWithTag("MenuFrame");
            filling.GetComponent<TabobjectsToggle>().enabled = true;
            GameObject createdobje = Instantiate(realobject, mouse, Quaternion.identity);
            createdobje.GetComponent<MousedragandR>().active = true;
            foreach (GameObject objecik in GameObject.FindGameObjectsWithTag("icon"))
            {
                objecik.GetComponent<MenuObject>().Sirala(sira);
            }
            
            GameObject.Destroy(this.gameObject);
            
        }
    }

}


