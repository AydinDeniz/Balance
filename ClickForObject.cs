using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickForObject : MonoBehaviour {

    public GameObject[] objects;
    public float hiz;
    public bool cooldown = true;
    Animator anim;
    public float scale_ratio;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    IEnumerator Wait()
    {
       
        int a = Random.Range(0, 2);
        GameObject Menuobject1 = Instantiate(objects[Random.Range(0, objects.Length)], new Vector3(Random.Range(-2.1f, 2.1f), 8, -0.01f), Quaternion.Euler(0, 0, Random.Range(0, 360)));
        Menuobject1.GetComponent<Rigidbody2D>().angularDrag = 0;
        Menuobject1.transform.localScale = new Vector2(Menuobject1.transform.localScale.x * scale_ratio, Menuobject1.transform.localScale.y * scale_ratio);
        if (a == 1)
        {
            Menuobject1.GetComponent<Rigidbody2D>().angularVelocity = -100;
        }
        else
        {
            Menuobject1.GetComponent<Rigidbody2D>().angularVelocity = 100;

        }
        yield return new WaitForSeconds(hiz);
        Menuobject1.GetComponent<Rigidbody2D>().angularDrag = 1;
        anim.Rebind();
        cooldown = true;
    }


    private void OnMouseDown()
    {
      
        if (cooldown == true)
        {
            anim.Play("Big");
            StartCoroutine(Wait());
            cooldown = false;
        }

    }
}
