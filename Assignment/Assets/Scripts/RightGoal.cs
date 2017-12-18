using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RightGoal : MonoBehaviour {
    LevelManager levelManager = new LevelManager(); // created an instance/copy of Level manager
    public int score;
    public static int TotalScore;
    public Text Score1;
    public string level;
    public int max;
    public int add;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Score1.text = score.ToString();


        if (score >= max)

        {
            
            score = 0;
            SceneManager.LoadScene(level);
            
            
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        score += add;
        TotalScore += add;
        
        print("Score: " + score + " TotalScore: " + TotalScore);
      

        

    }




}
