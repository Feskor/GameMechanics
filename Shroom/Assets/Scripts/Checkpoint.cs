using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private LevelManager lm;

    private void Start()
    {
        lm = GameObject.FindGameObjectWithTag("lm").GetComponent<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            lm.lastCheckpoint = transform.position;
        }
    }


}
