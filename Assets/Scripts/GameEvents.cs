using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
 * every single function assigned to this event will be executed 
 * when UpdateSquareNumberMethod is called
 */

public class GameEvents : MonoBehaviour
{
    public delegate void UpdateSquareNumber(int number); 
    public static event UpdateSquareNumber OnUpdateSquareNumber;

    public static void UpdateSquareNumberMethod(int number)
    {
        if (OnUpdateSquareNumber != null)
            OnUpdateSquareNumber(number);
    }

    public delegate void SquareSelected(int squareIndex);
    public static event SquareSelected OnSquareSelected;
    
    public static void SquareSelectedMethod(int squareIndex)
    {
        if (OnSquareSelected != null)
            OnSquareSelected(squareIndex);
    }
}
