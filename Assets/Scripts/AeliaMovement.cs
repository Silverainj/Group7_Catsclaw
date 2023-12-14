using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeliaMovement : MonoBehaviour
{
    Rigidbody2D rb; //access sto rigid body

    public float speed = 2f; //Sprite Speed
    float jumpSpeed = 15; //jump height
    float jumpForward = 1;


    void Start()
    {
        transform.Translate(0, 0, 0);
    }





    void Update()
    {


    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(jumpForward, jumpSpeed);
        }





    }
}
