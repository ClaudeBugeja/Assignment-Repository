using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RightGoal : MonoBehaviour {

    LevelManager levelManager = new LevelManager(); // created an instance/copy of Level manager
    public int score =0;
    public Text Score1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score1.text = score.ToString();
	}

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");

        score += 2;
        
         


        
    }

    
}
