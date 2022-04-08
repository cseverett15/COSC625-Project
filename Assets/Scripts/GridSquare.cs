using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GridSquare : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{

    public GameObject number_text;
    private int number = 0;

    private bool selected_ = false;
    private int squareIndex = -1;

    private bool IsSelected()
    {
        return selected_;
    }

    public void SetSquareIndex(int index)
    {
        squareIndex = index;
    }

    void Start()
    {
        selected_ = false;
        
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

    // When grid square is clicked the events in this function are executed
    public void OnPointerClick(PointerEventData eventData)
    {
        selected_ = true;
        GameEvents.SquareSelectedMethod(squareIndex);
    }

    public void OnSubmit(BaseEventData eventData)
    {

    }
    
    // adds function to event
    private void OnEnable()
    {
        GameEvents.OnUpdateSquareNumber += OnSetNumber;
        GameEvents.OnSquareSelected += OnSquareSelected;
    }
    
    // removes function from event
    private void OnDisable()
    {
        GameEvents.OnUpdateSquareNumber -= OnSetNumber;
        GameEvents.OnSquareSelected -= OnSquareSelected;
    }

    public void OnSetNumber(int number)
    {
        if (selected_)
        {
            SetNumber(number);
        }
    }

    public void OnSquareSelected(int sqrIndex)
    {
        if (squareIndex != sqrIndex)
        {
            selected_ = false;
        }

    }
}
