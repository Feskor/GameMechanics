using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerpos : MonoBehaviour {

    private LevelManager lm;


	// Use this for initialization
	void Start ()
    {
        lm = GameObject.FindGameObjectWithTag("lm").GetComponent<LevelManager>();
        transform.position = lm.lastCheckpoint;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position = lm.lastCheckpoint;
        }
	}
}
