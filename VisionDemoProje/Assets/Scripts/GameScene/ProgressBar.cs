using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;

    private bool stop;

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
        slider.value = slider.maxValue;
        StartCoroutine(DecreaseHealth());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private IEnumerator DecreaseHealth()
    {
        while (!stop)
        {
            slider.value -= 0.2f;
            yield return new WaitForSeconds(0.05f);
        }
        
    }
}
