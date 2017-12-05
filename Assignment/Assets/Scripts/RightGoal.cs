using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RightGoal : MonoBehaviour {

    LevelManager levelManager = new LevelManager(); // created an instance/copy of Level manager
    public static int score;
    public Text Score1;
    public string level;
    public int max;
    public int add;
    float position_y = 2f;
    float position_x = 5f;
    float position_z = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Score1.text = score.ToString();
        

        if (score >= max)

        {
            SceneManager.LoadScene(level);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Trigger");
        
        score += add;
      

        
    }




}
