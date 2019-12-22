using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_auto_yukari : MonoBehaviour {
    
    public int active = 0;
    public float smoothSpeed;
    int kova;
    float deltay;
    float eskiy=0;
    public GameObject[] objeler;
    public float tolarance;
    float highestFillingPosition;
    public Rigidbody2D rb2;


    void FixedUpdate()
    {
     
        
            
            objeler = GameObject.FindGameObjectsWithTag("object");
           
            highestFillingPosition = 0;
            for (int f = 0; f < objeler.Length; f++)
            {
                bool kodisimi = objeler[f].GetComponent<MousedragandR>().active;
                float thisY = objeler[f].transform.position.y; //cache this, because calculating it twice is also slower than need be
                
                if (thisY > highestFillingPosition && kodisimi==false)
                {
                    highestFillingPosition = thisY;
                    if (highestFillingPosition < 0)
                    {
                        highestFillingPosition = 0;
                    }

                }

            }
            deltay = highestFillingPosition - eskiy;
            eskiy = highestFillingPosition;
            if(highestFillingPosition!=0)
            {
                highestFillingPosition += tolarance;
            }
            rb2.velocity = new Vector2(0, 0);
            if (deltay < 0.001 && deltay > -0.001)
            {
                
                if (highestFillingPosition > this.transform.position.y)
                {
                
                    rb2.AddForce(new Vector2(0, 2 * smoothSpeed * Mathf.Abs(highestFillingPosition - this.transform.position.y )));
                    
                }
                if (highestFillingPosition < this.transform.position.y)
                {
                
                rb2.AddForce(new Vector2(0, -2 * smoothSpeed * Mathf.Abs(highestFillingPosition - this.transform.position.y)));
                    
                }
            }
        
    }
}
