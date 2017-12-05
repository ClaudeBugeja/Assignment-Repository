using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    public Text Score1;
    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;

    // Use this for initialization
    void Start() {

        paddle = GameObject.FindObjectOfType<Paddle>();
        ballPaddleDiff = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update() {

        if (!gameStarted) // if(gameStarted == false)
        {
            this.transform.position = paddle.transform.position + ballPaddleDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(2f, 10f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightGoal") {
            gameStarted = false;
        }
        if (collision.gameObject.name == "LeftGoal"){
            gameStarted = false;
        }
    }

}

