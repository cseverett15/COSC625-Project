using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CountdownTimer : MonoBehaviour
{

    
    float currentTime = 0f;
    float startingTime = 40f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (currentTime == 0 || currentTime <= 0)
        {
            currentTime = 0;
        }
        else
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
        }

        
        
    }
    
}
