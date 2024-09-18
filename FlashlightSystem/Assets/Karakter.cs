using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameObject Isik;

    private bool isikAcikmi;
    // Start is called before the first frame update
    void Start()
    {
        isikAcikmi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))    
        {
            isikAcikmi = !isikAcikmi;
            Isik.SetActive(isikAcikmi);
        }
    }
}
