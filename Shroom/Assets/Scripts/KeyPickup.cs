using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour {

    public AudioClip pickUp;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(pickUp, transform.position);
            gameObject.SetActive(false);
            other.GetComponent<PlayerMovement>().hasKey1 = true;
        }
    }
}
