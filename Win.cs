using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    int active = 0;
    bool basladi = false;
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
        Debug.Log(3);
        yield return new WaitForSeconds(1);
        Debug.Log(2);
        yield return new WaitForSeconds(1);
        Debug.Log(1);
        yield return new WaitForSeconds(1);
        Debug.Log("YOU WIN");
    }


    
    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "object" && coll.GetComponent<MousedragandR>().active == true)
        {
            basladi = false;
            StopAllCoroutines();
        }
        else if (coll.tag == "object" && coll.GetComponent<MousedragandR>().active == false && basladi == false)
        {
            basladi = true;
            StartCoroutine(Wait());
        }
    }



    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "object")
        {
            basladi = false;
            active -= 1;
            StopAllCoroutines();
        }
    }

    
}
