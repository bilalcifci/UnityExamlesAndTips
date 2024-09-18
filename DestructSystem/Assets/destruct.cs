using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour
{

   public GameObject patlamaefekti;

    void Update()
    {
        

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.CompareTag("Dusman"))
                {

                    GameObject efekt= Instantiate(patlamaefekti, hit.transform.position, hit.transform.rotation);

                    hit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;

                    Transform[] cocuklar = hit.transform.gameObject.GetComponentsInChildren<Transform>();

                    foreach (var gelencocuklar in cocuklar)
                    {

                        gelencocuklar.gameObject.AddComponent<Rigidbody>();
                    }


                    Destroy(efekt, 2f);
                    /// YÖNTEM 1
                   /* Instantiate(kirilacakobje, hit.transform.position, hit.transform.rotation);
                    Destroy(hit.transform.gameObject);*/

                }


            }


           


        }


    }
}
