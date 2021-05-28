using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject sliderObject;
    public GameObject gameOverMenu;


    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = sliderObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value <= 0)
        {
            gameOverMenu.SetActive(true);
            
        }
    }

    
}
