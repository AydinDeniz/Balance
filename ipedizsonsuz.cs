using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ipedizsonsuz : MonoBehaviour
{
    public float ekrangenisligi = 7;
    public GameObject frame;
    public GameObject[] objects;




    IEnumerator Wait(Vector3 pos)
    {


        yield return new WaitForSeconds(0.4f);
        
        int random = Random.Range(0, objects.Length);
        Debug.Log("ol");
        GameObject Menuobject1 = Instantiate(objects[random], new Vector3(pos.x,transform.position.y,-0.01f), Quaternion.identity);




        Menuobject1.transform.parent = transform;



        yield return new WaitForSeconds(0.2f);


    }




    void Start()
    {


        var slots = new float[3];
        slots[0] = -ekrangenisligi / 4;
        int sayac1 = 1;

        for (int i = 1; i != 3; i++)
        {
            slots[sayac1] = slots[sayac1 - 1] + ekrangenisligi / 4;
            sayac1++;

        }

        int sayac = 0;

        while (true)
        {
            if(sayac==3)
            {
                break;
            }
            int random = (Random.Range(0, objects.Length ));
            GameObject Menuobject1 = Instantiate(objects[random], new Vector3(slots[sayac], transform.position.y, -0.01f), Quaternion.identity);




            Menuobject1.transform.parent = transform;
            sayac++;
        }

        
    }

    public void Genrandom(Vector3 pos)
    {
        StartCoroutine(Wait(pos));
    }

    private void Update()
    {
        transform.position = new Vector2(transform.position.x, frame.transform.position.y - 0.15f);
    }











}
