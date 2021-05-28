using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class AdvertisementScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject advertisement;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!videoPlayer.isPlaying)
        {
            PlayerPrefs.DeleteKey("kalp1");
            PlayerPrefs.DeleteKey("kalp2");
            PlayerPrefs.DeleteKey("kalp3");
            PlayerPrefs.DeleteKey("heartNumber");
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            

            advertisement.SetActive(false);
            panel.SetActive(false);
            
        }

        
    }

    
}
