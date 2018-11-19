using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour {

    public AudioClip doorOpen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerMovement>().hasKey1)
        {
            AudioSource.PlayClipAtPoint(doorOpen, transform.position);
            this.gameObject.SetActive(false);
        }
    }

}
