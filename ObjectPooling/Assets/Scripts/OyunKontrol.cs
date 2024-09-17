using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject[] OlusacakObje;

    public GameObject OlusacakNokta;

    private int SiraNumarasi = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        // OlusacakObje[0].SetActive(true);
        // OlusacakObje[0].transform.position = OlusacakNokta.transform.position;
        StartCoroutine(ObjeOlustur());
    }
    IEnumerator ObjeOlustur()
    {
        while (true)
        {
            if (SiraNumarasi < OlusacakObje.Length)
            {
                if (OlusacakObje[SiraNumarasi].activeSelf == false)
                {
                    IvmeKontrol(OlusacakObje[SiraNumarasi]);
                    OlusacakObje[SiraNumarasi].SetActive(true);
                    OlusacakObje[SiraNumarasi].transform.position = OlusacakNokta.transform.position;
                }
                SiraNumarasi++;
            }
            else
            {
                SiraNumarasi = 0;
                if (OlusacakObje[SiraNumarasi].activeSelf == false)
                {
                    IvmeKontrol(OlusacakObje[SiraNumarasi]);
                    OlusacakObje[SiraNumarasi].SetActive(true);
                    OlusacakObje[SiraNumarasi].transform.position = OlusacakNokta.transform.position;
                }

                
                SiraNumarasi++;
            }
            
            // foreach (GameObject VARIABLE in OlusacakObje)
            // {
            //     VARIABLE.transform.position = OlusacakNokta.transform.position;
            //     VARIABLE.SetActive(true);
            // }
            
            yield return new WaitForSeconds(.5f);
        }
    }

    private void IvmeKontrol(GameObject obj)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (obj.activeSelf == false)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
