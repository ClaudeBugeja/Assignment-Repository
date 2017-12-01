using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeftGoal : MonoBehaviour {
    public int score2 = 0;
    public Text Scoreplay;
    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    // Use this for initialization
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        ballPaddleDiff = this.transform.position - paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Scoreplay.text =""+ score2;
       
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        score2 += 2;
        this.transform.position = paddle.transform.position + ballPaddleDiff;
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
}
