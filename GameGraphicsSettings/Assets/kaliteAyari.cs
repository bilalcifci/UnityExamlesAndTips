using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaliteAyari : MonoBehaviour
{
    public Dropdown kaliteDrop;
    void Start()
    {
        
        if (PlayerPrefs.HasKey("Kalite"))
        {
            kaliteDrop.value = PlayerPrefs.GetInt("Kalite");
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Kalite"));

        }else
        {
            PlayerPrefs.SetInt("Kalite", 2);
            kaliteDrop.value = 2;
           
        }


    }

    public void KaliteAyari(int kaliteayari)
    {
        PlayerPrefs.SetInt("Kalite", kaliteayari);

        QualitySettings.SetQualityLevel(kaliteayari);

     }
}
