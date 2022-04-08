using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// creates easy difficulty grid when selected from start menu
public class EasyData : MonoBehaviour
{

    /*  We will either need to generate the puzzles with a generator 
         *  or find a library of sudoku puzzles that we can just add to 
         *  each difficulty class
         */
    public static List<Sudoku_Data.BoardData> getData()
    {
        List<Sudoku_Data.BoardData> data = new List<Sudoku_Data.BoardData>();


        data.Add(new Sudoku_Data.BoardData(
            //unsolved data
            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0,
                         0, 3, 0, 5, 1, 0, 8, 0, 0,
                         0, 8, 0, 0, 0, 9, 0, 0, 0,
                         4, 0, 1, 8, 0, 0, 6, 0, 0,
                         0, 0, 3, 0, 5, 0, 4, 0, 0,
                         0, 0, 6, 0, 0, 7, 2, 0, 0,
                         9, 0, 0, 7, 0, 0, 0, 4, 0,
                         0, 0, 5, 0, 8, 0, 0, 0, 2,
                         0, 4, 0, 3, 2, 0, 7, 1, 0},

            //solved data
            new int[81] {2, 1, 4, 6, 7, 8, 9, 3, 5,
                         3, 6, 9, 5, 1, 2, 8, 7, 4,
                         5, 8, 7, 4, 3, 9, 1, 2, 6,
                         4, 2, 1, 8, 9, 3, 6, 5, 7,
                         7, 9, 3, 2, 5, 6, 4, 8, 1,
                         8, 5, 6, 1, 4, 7, 2, 9, 3,
                         9, 3, 2, 7, 6, 1, 5, 4, 8,
                         1, 7, 5, 9, 8, 4, 3, 6, 2,
                         6, 4, 8, 3, 2, 5, 7, 1, 9}));

        return data;


    }

}

// creates medium difficulty grid when medium is selected from start menu
public class MedData : MonoBehaviour
{
    public static List<Sudoku_Data.BoardData> getData()
    {
        List<Sudoku_Data.BoardData> data = new List<Sudoku_Data.BoardData>();


        data.Add(new Sudoku_Data.BoardData(
            //unsolved data
            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0,
                         0, 3, 0, 5, 1, 0, 8, 0, 0,
                         0, 8, 0, 0, 0, 9, 0, 0, 0,
                         4, 0, 1, 8, 0, 0, 6, 0, 0,
                         0, 0, 3, 0, 5, 0, 4, 0, 0,
                         0, 0, 6, 0, 0, 7, 2, 0, 0,
                         9, 0, 0, 7, 0, 0, 0, 4, 0,
                         0, 0, 5, 0, 8, 0, 0, 0, 2,
                         0, 4, 0, 3, 2, 0, 7, 1, 0},

            //solved data
            new int[81] {2, 1, 4, 6, 7, 8, 9, 3, 5,
                         3, 6, 9, 5, 1, 2, 8, 7, 4,
                         5, 8, 7, 4, 3, 9, 1, 2, 6,
                         4, 2, 1, 8, 9, 3, 6, 5, 7,
                         7, 9, 3, 2, 5, 6, 4, 8, 1,
                         8, 5, 6, 1, 4, 7, 2, 9, 3,
                         9, 3, 2, 7, 6, 1, 5, 4, 8,
                         1, 7, 5, 9, 8, 4, 3, 6, 2,
                         6, 4, 8, 3, 2, 5, 7, 1, 9}));

        return data;


    }
}

//creates hard difficulty grid when selected from menu
public class HardData : MonoBehaviour
{
    public static List<Sudoku_Data.BoardData> getData()
    {
        List<Sudoku_Data.BoardData> data = new List<Sudoku_Data.BoardData>();


        data.Add(new Sudoku_Data.BoardData(
            //unsolved data
            new int[81] {0, 1, 0, 0, 0, 0, 0, 3, 0,
                         0, 3, 0, 5, 1, 0, 0, 0, 0,
                         0, 0, 0, 0, 0, 9, 0, 0, 0,
                         4, 0, 1, 0, 0, 0, 6, 0, 0,
                         0, 0, 0, 0, 5, 0, 4, 0, 0,
                         0, 0, 6, 0, 0, 7, 2, 0, 0,
                         9, 0, 0, 7, 0, 0, 0, 4, 0,
                         0, 7, 5, 0, 0, 4, 0, 0, 2,
                         0, 0, 0, 3, 2, 0, 0, 1, 0},
            //solved data
            new int[81] {2, 1, 4, 6, 7, 8, 9, 3, 5,
                         3, 6, 9, 5, 1, 2, 8, 7, 4,
                         5, 8, 7, 4, 3, 9, 1, 2, 6,
                         4, 2, 1, 8, 9, 3, 6, 5, 7,
                         7, 9, 3, 2, 5, 6, 4, 8, 1,
                         8, 5, 6, 1, 4, 7, 2, 9, 3,
                         9, 3, 2, 7, 6, 1, 5, 4, 8,
                         1, 7, 5, 9, 8, 4, 3, 6, 2,
                         6, 4, 8, 3, 2, 5, 7, 1, 9}));

        return data;


    }
}




public class Sudoku_Data : MonoBehaviour
{
     //instantiation of Sudoku_Data class
    public static Sudoku_Data Instance;

    public struct BoardData
    {
        public int[] unsolved_data;
        //array to check against user answers
        public int[] solved_data;

        public BoardData(int[] unsolved, int[] solved)
        {
            this.unsolved_data = unsolved;
            this.solved_data = solved;
        }
    }
    /* dictionary to hold list of all data
     * this will be used for the different difficulties
     */
    public Dictionary<string, List<BoardData>> sudoku_game = new Dictionary<string, List<BoardData>>();

    private void Awake()
    {   //will not allow to create more than one instance of this object in a game
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        sudoku_game.Add("Easy", EasyData.getData());
        sudoku_game.Add("Medium", MedData.getData());
        sudoku_game.Add("Hard", HardData.getData());
    }

    void Update()
    {
        
    }
}
