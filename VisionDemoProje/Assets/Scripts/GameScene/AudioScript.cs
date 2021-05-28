using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("ses"))
        {
            if (PlayerPrefs.GetInt("ses") == 1)
            {
                audioSource.Play();
            }
            else if(PlayerPrefs.GetInt("ses") == 0)
            {
                audioSource.playOnAwake = false;
                audioSource.Stop();
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
