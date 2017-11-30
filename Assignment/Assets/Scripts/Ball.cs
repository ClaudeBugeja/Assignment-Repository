﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
      
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
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}


	}

