using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
    public Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        IsTogglePrefs();
    }

    // Update is called once per frame
    void Update()
    {
        
        IsToggleOn();
    }

    private void IsToggleOn()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("ses", 1);
            PlayerPrefs.SetInt("toggle", 1);
            //Debug.Log("Ses Açık");

        }
        else
        {
            PlayerPrefs.SetInt("ses", 0);
            PlayerPrefs.SetInt("toggle", 0);
            //Debug.Log("Ses Kapalı");

        }
    }

    private void IsTogglePrefs()
    {
        if (PlayerPrefs.HasKey("toggle"))
        {
            if(PlayerPrefs.GetInt("toggle") == 0)
            {
                toggle.isOn = false;
            }
            else if(PlayerPrefs.GetInt("toggle") == 1)
            {
                toggle.isOn = true;
            }
        }
    }


}
