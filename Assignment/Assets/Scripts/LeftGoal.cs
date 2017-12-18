using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeftGoal : MonoBehaviour {
    LevelManager levelManager = new LevelManager();
    public int score2 ;
    public static int TotalScore2;
    public Text Scoreplay;
    public int max;
    public int add;
    public string level;
    // Use this for initialization
    void Start () {
       // Scoreplay.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        Scoreplay.text = score2.ToString();
        
        if (score2 >= max)

        {
            score2 = 0;
            SceneManager.LoadScene(level);
           
           
            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        score2 += add;
        TotalScore2 += add;

        print("Score 2: " + score2 + " TotalScore2: " + TotalScore2);
       
    }
}
