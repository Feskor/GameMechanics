﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject platform;
    public float speed = 3f;
    public Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
	// Use this for initialization
	void Start ()
    {
        currentPoint = points[pointSelection];
	}
	
	// Update is called once per frame
	void Update ()
    {
        platform.transform.position = Vector2.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime * speed);
        
        if(platform.transform.position == currentPoint.position)
        {
            pointSelection++;

            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
            
        }
        //Debug.Log(platform.transform.position + " " + currentPoint.position);
	}
}
