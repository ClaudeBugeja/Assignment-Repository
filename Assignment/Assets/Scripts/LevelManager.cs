using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
    public Text finalScore2;
    public Text Player1Score;
    public Text Loser;
    public Text Winner;


    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        TotalScorePlayer2();
        TotalScorePlayer1();
        if (LeftGoal.TotalScore2 > RightGoal.TotalScore)
        {
            Loser.text = "Winner";
            Loser.color = Color.green;
            Winner.text = "Loser";
            Winner.color = Color.red; 
        }
        else if (LeftGoal.TotalScore2 < RightGoal.TotalScore)
        {
            Loser.text = "Loser";
            Loser.color = Color.red;
            Winner.text = "Winner";
            Winner.color = Color.green;
        }
        else if (LeftGoal.TotalScore2 == RightGoal.TotalScore)
        {
            Loser.text = "Draw";
            Loser.color = Color.blue;
            Winner.text = "Draw";
            Winner.color = Color.blue;
        }
    }
    public void TotalScorePlayer1()
    {
        Player1Score.text = "Player 1 : " + RightGoal.TotalScore;

       

    }
    public void TotalScorePlayer2()
    {
        finalScore2.text = "Player 2 : "+LeftGoal.TotalScore2;
        
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");
        RightGoal.TotalScore = 0;
        LeftGoal.TotalScore2 = 0;
    }
}