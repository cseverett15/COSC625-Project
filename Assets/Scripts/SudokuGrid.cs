using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuGrid : MonoBehaviour
{
    public int columns = 0;
    public int rows = 0;
    public float every_square_offset = 0.0f;
    public Vector2 start_position = new Vector2(0.0f, 0.0f);
    public float square_scale = 1.0f;

    public GameObject grid_square;

    private List<GameObject> grid_squares = new List<GameObject>();
   
    //chooses difficulty
    private int select_grid_data = -1;


    void Start()
    {
        if (grid_square.GetComponent<GridSquare>() == null)
            Debug.LogError("grid_square object need to have GridSquare script attached!");
        CreateGrid();
        
        // Sets difficulty based on what the user selects
        SetGridNumbers(GameSettings.Instance.GetGameMode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //creates grid
    private void CreateGrid() 
    {
        SpawnGridSquares();
        SetSquaresPosition();
    }

    private void SpawnGridSquares() 
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                grid_squares.Add(Instantiate(grid_square) as GameObject);
               
                //instantiates this game object as a child of the object holding this script
                grid_squares[grid_squares.Count - 1].transform.parent = this.transform;
                grid_squares[grid_squares.Count - 1].transform.localScale = new Vector3(square_scale, square_scale, square_scale);

            }
        };
    }

    //sets positions for gridsquare
    private void SetSquaresPosition() 
    {
        var square_rect = grid_squares[0].GetComponent<RectTransform>();
        Vector2 offset = new Vector2();
        offset.x = square_rect.rect.width * square_rect.transform.localScale.x + every_square_offset;
        offset.y = square_rect.rect.height * square_rect.transform.localScale.y + every_square_offset;

        int column_number = 0;
        int row_number = 0;

        foreach (GameObject square in grid_squares)
        {
            if (column_number + 1 > columns)
            {
                row_number++;
                column_number = 0;
            }

            var pos_x_offset = offset.x * column_number;
            var pos_y_offset = offset.y * row_number;
            square.GetComponent<RectTransform>().anchoredPosition = new Vector3(start_position.x + pos_x_offset, start_position.y - pos_y_offset);
            column_number++;
        }
    }

    private void SetGridNumbers(string level) 
    {

        select_grid_data = Random.Range(0, Sudoku_Data.Instance.sudoku_game[level].Count);
        var data = Sudoku_Data.Instance.sudoku_game[level][select_grid_data];

        setGridSquareData(data);
        
        /* foreach(var square in grid_squares)
        {
            square.GetComponent<GridSquare>().SetNumber(Random.Range(0, 10));
        }*/
    }

    private void setGridSquareData(Sudoku_Data.BoardData data)
    {
        for(int index = 0; index < grid_squares.Count; index++)
        {
            grid_squares[index].GetComponent<GridSquare>().SetNumber(data.unsolved_data[index]);
        }
    }
}
