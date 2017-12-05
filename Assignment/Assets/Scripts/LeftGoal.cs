using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeftGoal : MonoBehaviour {
    LevelManager levelManager = new LevelManager();
    public static int score2 ;
    public Text Scoreplay;
    public int max;
    public int add;
    public string level;
    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Scoreplay.text = score2.ToString();

        if (score2 >= max)

        {
            SceneManager.LoadScene(level);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        score2 += add;
    }
}
