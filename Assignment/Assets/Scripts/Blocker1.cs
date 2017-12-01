using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker1 : MonoBehaviour {
    public GameObject Blocker;
    
    // Use this for initialization
    void Start () {
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        Instantiate(Blocker, position, Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {

        
    }
}
