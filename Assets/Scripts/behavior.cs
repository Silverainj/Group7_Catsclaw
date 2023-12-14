using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour
{
    Rigidbody2D rb; //access sto rigid body

    public float speed = 10f; //Sprite Speed
    public float jump_speed = 3f; //Jump Speed
    public float limit = 10;
    public float neglimit = -10;
    public float limity = 4;
    public float neglimity = -4;
    public float acc = 6;

    float jumpSpeed = 25;
    float jumpForward=0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        if (transform.position.x >= limit)
        {
            Vector3 v = transform.position;
            v.x = limit;
            transform.position = v;
        }

        if (transform.position.x <= neglimit)
        {
            Vector3 v = transform.position;
            v.x = neglimit;
            transform.position = v;
        }

        if (transform.position.y >= limity)
        {
            Vector3 v = transform.position;
            v.y = limity;
            transform.position = v;
        }

        if (transform.position.y <= neglimity)
        {
            Vector3 v = transform.position;
            v.y = neglimity;
            transform.position = v;
        }
    }
    void FixedUpdate()
    {

        //rb.velocity += new Vector2(Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime, Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime);
        rb.velocity += new Vector2(Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = new Vector2(jumpForward, jumpSpeed);
        }



        

    }
}
