using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker1 : MonoBehaviour {
    public GameObject Blocker;
    float position;
   
    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        float i = transform.position.y;
        
        Vector3 newPos = new Vector3(gameObject.transform.position.x, i, gameObject.transform.position.z);
        gameObject.transform.position = newPos;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0f,position,1f );

        if (i <= 3.5f)
        {
            Vector3 Pos = new Vector3(gameObject.transform.position.x, i, gameObject.transform.position.z);
            gameObject.transform.position = Pos;

        }
        if(i >= -7.5f)
        {
          
       }
    }
}
