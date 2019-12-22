using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEffects : MonoBehaviour {

    public bool clickscale;
    public bool leftright;
    public bool cooldown;
    public float scaleoran;
    public float hiz;
    public bool scaleactive;
    public bool swap;
    IEnumerator Wait()
    {
        Debug.Log("scale down");
        yield return new WaitForSeconds(1);
        swap = true;
        Debug.Log("scale up");
        yield return new WaitForSeconds(1);
        scaleactive = false;
        swap = false;
        Debug.Log("ENDED");
    }
    void Update ()
    {
		if(scaleactive==true)
        {
           
            if (swap==true)
            {
                Debug.Log("EBNE UP");
               this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x * scaleoran, this.transform.localScale.y * scaleoran, this.transform.localScale.z);
            }
            else
            {
                Debug.Log("EBNE DOWN");
                this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x / scaleoran, this.transform.localScale.y / scaleoran, this.transform.localScale.z);
            }
        }
	}

    private void OnMouseDown()
    {
        if(clickscale==true & scaleactive==false)
        {
            Debug.Log("start scale");
            scaleactive = true;
            StartCoroutine(Wait());
            
            swap = false;
        }
    }
}
