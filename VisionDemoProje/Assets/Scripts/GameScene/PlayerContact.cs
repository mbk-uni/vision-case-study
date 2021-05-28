using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContact : MonoBehaviour
{
    public GameObject progressBar;
    public Text energyNumber;

    private Slider slider;
    private int point = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        slider = progressBar.GetComponent<Slider>();
        energyNumber.text = point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obje")
        {
            point++;
            energyNumber.text = point.ToString();
            if(slider.value + 10 < slider.maxValue)
            {
                slider.value += 10;
            }
        }
    }
}
