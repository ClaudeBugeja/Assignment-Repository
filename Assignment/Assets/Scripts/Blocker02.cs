using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker02 : MonoBehaviour {
    public GameObject Blocker2;
    public int movement;
    private Vector3 startPos2;
    // Use this for initialization
    void Start () {
        startPos2 = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, startPos2.y + Mathf.Sin(Time.time * movement), transform.position.z);
        if (transform.position.y > 3.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.y < -3.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
