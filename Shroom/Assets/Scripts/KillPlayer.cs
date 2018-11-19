using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    private LevelManager lm;

    private void Start()
    {
        lm = GameObject.FindGameObjectWithTag("lm").GetComponent<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            lm.Respawn();
        }
    }
}
