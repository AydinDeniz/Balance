using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stabilizer : MonoBehaviour {
    public GameObject obje;
    public float y;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        {
            if (coll.transform.tag == "object")
            {
                coll.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }
            else if(coll.transform.tag=="sonsuztrigger")
            {
                GameObject obje1 = Instantiate(obje, new Vector3(0, y, 0), Quaternion.Euler(0, 0,0));
            }
        }
    }



}
