using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : Selectable
{

    public GameObject number_text;
    private int number = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayText()
    {   // numbers in data set to zero will be the blank grid quares on the grid
        if(number <= 0)
        {
            number_text.GetComponent <Text>().text = " ";

        }else
        {
            number_text.GetComponent<Text>().text = number.ToString();
        }
    }

    public void SetNumber(int number_)
    {
        number = number_;
        DisplayText();
    }

}
