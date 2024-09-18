using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    public GameObject[] noktalar;
    Transform gecerlinokta;
    Vector3 poz;
    int devriyeNoktaSayisi=0;
    void Start()
    {
        gecerlinokta = noktalar[0].transform;
    }

    // Update is called once per frame
    void Update()
    {

        poz = gecerlinokta.position - transform.position;
        transform.Translate(poz.normalized * 5f * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position,gecerlinokta.position) <= .1f)
        {
            BirsonrakiPozisyonagit();

        }

    }

    void BirsonrakiPozisyonagit ()
    {

        if (devriyeNoktaSayisi >= noktalar.Length -1)
        {
            Debug.Log("bitti");
            return;
        }
        devriyeNoktaSayisi++; //1 // 2
        gecerlinokta = noktalar[devriyeNoktaSayisi].transform;



    }
}
