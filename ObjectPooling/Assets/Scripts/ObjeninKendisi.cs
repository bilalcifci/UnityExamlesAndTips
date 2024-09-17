using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeninKendisi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (other.gameObject.CompareTag("Pasiflestir") && other.gameObject.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
    }
}
