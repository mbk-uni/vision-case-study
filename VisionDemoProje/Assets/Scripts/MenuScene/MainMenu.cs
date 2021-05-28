using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject popUp;
    public GameObject panel;
    

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject playButton;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (PlayerPrefs.HasKey("kalp1"))
        {
            heart1.SetActive(false);
        }

        if (PlayerPrefs.HasKey("kalp2"))
        {
            heart2.SetActive(false);
        }

        if (PlayerPrefs.HasKey("kalp3"))
        {
            heart3.SetActive(false);
        }
    }

    public void Play()
    {
        

        if (!heart3.activeInHierarchy)
        {
            panel.SetActive(true);
            popUp.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(1);
            if (PlayerPrefs.HasKey("heartNumber") == false)
            {

                PlayerPrefs.SetInt("heartNumber", 1);
                PlayerPrefs.SetString("kalp1", "1");
                //Debug.Log("İlk kalp");


            }
            else
            {
                if (PlayerPrefs.GetInt("heartNumber") == 1)
                {
                    PlayerPrefs.SetInt("heartNumber", 2);
                    PlayerPrefs.SetString("kalp2", "2");
                    //Debug.Log("İkinci kalp");
                }
                else
                {
                    PlayerPrefs.SetInt("heartNumber", 3);
                    PlayerPrefs.SetString("kalp3", "3");
                    
                    //Debug.Log("Üçüncü kalp");
                }
            }
        }
        
        
            
        
        
        
    }

    public void OpenOptions()
    {
        panel.SetActive(true);
        optionsMenu.SetActive(true);

    }

    public void Quit()
    {
        //Debug.Log("Quit Game");
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void CloseOptions()
    {
        panel.SetActive(false);
        optionsMenu.SetActive(false);

    }

    

    
}
