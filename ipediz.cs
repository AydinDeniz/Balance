using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ipediz : MonoBehaviour {
    
    public float ekrangenisligi = 7;
    public int objesayisi;
    public GameObject[] objects;
    public bool activeM = true;
    public Rigidbody2D rb2;
    public int kuvvet;
    Vector2 fark;
    public GameObject frame;
    
    
    


    public GameObject slider;
    void Start ()
    {
        

        var slots = new float[objesayisi];
        slots[0] = -ekrangenisligi/2+ekrangenisligi/8;
        
        
        for(int i=1; i!=objesayisi; i++)
        {
            slots[i] = slots[i-1] + ekrangenisligi / 4;

          
        }
       
        int sayac = 0;
        
        foreach (GameObject obje in objects)
        {
            GameObject Menuobject1 =Instantiate(obje, new Vector3(slots[sayac], slider.transform.position.y,0), Quaternion.identity);

          
          

            Menuobject1.transform.parent = slider.transform;
            sayac++;
        }
       
    }

    


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            activeM = true;
            Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            fark = Camera.main.ScreenToWorldPoint(mouse) - transform.position;
        }
    }

   


    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            activeM = false;
            rb2.velocity = new Vector2(0, 0);
        }
       

        transform.position = new Vector2(transform.position.x, frame.transform.position.y-0.15f);
        rb2.velocity = new Vector2(0, 0);
        if (activeM == true)
        {

           

            Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            mouse = Camera.main.ScreenToWorldPoint(mouse); ;
       

            
                rb2.AddForce(((mouse - fark - new Vector2(this.transform.position.x, 0))) * kuvvet * new Vector2(1, 0));
            
               
            
            



        }
        int varolaniconsayisi = GameObject.FindGameObjectsWithTag("icon").Length;



        if ( varolaniconsayisi < 5)
        {
            transform.position = new Vector2(0, transform.position.y);
        }

        if (this.transform.position.x > 0)
        {
            
            transform.position = new Vector2(0, transform.position.y);
        }

        if (this.transform.position.x < -((varolaniconsayisi - 4) * ekrangenisligi / 4))
        {
            
            transform.position = new Vector2( - ((varolaniconsayisi - 4) * ekrangenisligi / 4), transform.position.y);
        }
        
        

    }



        
    
}
