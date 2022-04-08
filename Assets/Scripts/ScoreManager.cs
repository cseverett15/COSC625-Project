using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    /*public GameSettings gameSettings;
    private int difficulty;*/

    public Text playerScore;
    public Text computerScore;
    public Text countdownDisplay;

    int player_score = 0;
    int computer_score = 0;
    int countdownTime = 40;

    private void Awake()
    {
        //gameSettings = GameObject.FindObjectOfType<gameSettings>();
        instance = this;
    }

    // Maps score text to Canvas object
    void Start()
    {
        playerScore.text = "Player Score: " + player_score.ToString();
        computerScore.text = "Computer Score: " + computer_score.ToString();
    }

    public void PlayerScore()
    {
        player_score += 1;
        playerScore.text = "Player Score: " + player_score.ToString();

    }

    public void ComputerScore()
    {
        player_score += 1;
        computerScore.text = "Computer Score: " + computer_score.ToString();  
    }
}
