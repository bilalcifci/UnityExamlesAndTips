using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSistemi : MonoBehaviour
{
    public GameObject[] paneller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButonaBasildi(int index)
    {

        foreach (var gelenpanel in paneller)
        {
            gelenpanel.SetActive(false);
        }

        paneller[index].SetActive(true);

    }
}
