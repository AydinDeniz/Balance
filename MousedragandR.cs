using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousedragandR : MonoBehaviour
{
   
    public Rigidbody2D rb2;
    public int kuvvet;
    Vector2 fark;
    public bool active=false;
    
    public float donmehizi;
    public Vector2 mouseB=new Vector2(0,-90);
    public float buyukvector;

    void OnMouseDown()
    {
        
            active = true;
            Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            fark = Camera.main.ScreenToWorldPoint(mouse) - transform.position;
            

        
    }
 
    




    void Update()
    {

        if(Input.GetMouseButtonUp(0))
        {
            active = false;
        }


            if ( active == true)
        {
            
            
            Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            mouse = Camera.main.ScreenToWorldPoint(mouse); ;
           



            Vector2 movevector = mouse - fark - new Vector2(this.transform.position.x, this.transform.position.y);
            

            if(Mathf.Abs(movevector.x)> Mathf.Abs(movevector.y))
            {
                buyukvector = Mathf.Abs(movevector.x);
            }
            else
            {
                buyukvector = Mathf.Abs(movevector.y); 
            }
            if(buyukvector>0.4f)
            {
                float oran = buyukvector / 0.4f;
                movevector.x = movevector.x / oran;
                movevector.y = movevector.y / oran;
            }
            
            rb2.AddForce((movevector) * rb2.mass*300);


            if (Input.GetMouseButton(0))
            {


                if (Input.GetKey(KeyCode.A))
                { 
                    rb2.AddTorque(donmehizi);

                }
                if (Input.GetKey(KeyCode.D))
                {
                    
                    rb2.AddTorque(-donmehizi);
                }
                
            }
            rb2.velocity = new Vector2(0, 0);
        }



        
    }
}

