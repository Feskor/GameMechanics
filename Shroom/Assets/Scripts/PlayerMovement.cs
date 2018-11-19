using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public bool canWallJump = false;
    public bool hasKey1 = false;

    float movementH;
    public float speed = 10f;

    bool jump = false;
    public CharacterController2D controller;

    private void Update()
    {
        movementH = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
        controller.Move(movementH * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
