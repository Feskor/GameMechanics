using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

    Collider2D col;
    public AudioClip abilityUp;
	// Use this for initialization
	void Start ()
    {
        col = GetComponent<BoxCollider2D>();
	}


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(abilityUp, transform.position);
            LevelManager.Instance.PlayerMovement.canWallJump = true;
        }
    }
        
    
}
