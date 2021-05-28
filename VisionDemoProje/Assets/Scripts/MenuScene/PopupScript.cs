using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PopupScript : MonoBehaviour
{
    public GameObject advertisement;
    public GameObject videoPlayer;
    public GameObject panel;
    public GameObject popUp;

    private VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = videoPlayer.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Yes()
    {
        popUp.SetActive(false);
        advertisement.SetActive(true);
        player.Play();

    }

    public void No()
    {
        panel.SetActive(false);
        popUp.SetActive(false);

    }
}
