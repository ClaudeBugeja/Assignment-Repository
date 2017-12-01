using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        float position_y = transform.position.y;


        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (position_y > 2.5f)
            {
                position_y = 2.5f;
            }
            else
            {
                Vector3 newpos = this.transform.position;
                newpos.y++;
                this.transform.position = newpos;
            }
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (position_y < -6.7f)
            {
                position_y = -6.7f;
            }
            else
            {
                Vector3 newpos = this.transform.position;
                newpos.y--;
                this.transform.position = newpos;
            }
        }

     
    }
}
