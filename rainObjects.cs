using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainObjects : MonoBehaviour {

    public GameObject[] objects;
    public float hiz;
    public float scaleoran;


    IEnumerator Wait()
    {

        yield return new WaitForSeconds(hiz);
        GameObject Menuobject1 = Instantiate(objects[Random.Range(0,objects.Length)], new Vector3(Random.Range(-2.1f, 2.1f), 8, -0.01f), Quaternion.Euler(0,0, Random.Range(0, 360)));
        int a = Random.Range(0,2);
        Menuobject1.transform.localScale = new Vector3(Menuobject1.transform.localScale.x/scaleoran, Menuobject1.transform.localScale.y / scaleoran,Menuobject1.transform.localScale.z);
        Menuobject1.GetComponent<Rigidbody2D>().angularDrag = 0;
        if (a == 1)
        {
            Menuobject1.GetComponent<Rigidbody2D>().angularVelocity = -100;
        }
        else
        {
            Menuobject1.GetComponent<Rigidbody2D>().angularVelocity = 100;
            
        }
        
        StartCoroutine(Wait());
    }
    

    private void Start()
    {
        StartCoroutine(Wait());
    }
}
