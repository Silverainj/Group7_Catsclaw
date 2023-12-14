using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aelia_Movement : MonoBehaviour
{
    Rigidbody2D rb; //access sto rigid body

    public float speed = 4; //Sprite Speed?????
    public float jump_speed = 6; //Jump Speed??????
    //public float acc = 6; //epitaxinsi gia fixedupdate
    //public float x;
    public float limit = 15;
    public float neglimit = -15;
    public float limity = 4;
    //public float neglimity = -4;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.Translate(0, 0, 0);
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


        if (Input.GetButtonDown("Jump"))
        {
            //transform.Translate(0, jump_speed, 0, Space.World);

            rb.velocity += new Vector2(0, jump_speed);
        }

        /*

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0, Space.World);
        //transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        


        if (Input.GetAxis("Horizontal") * speed * Time.deltaTime > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") * speed * Time.deltaTime < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        */


    }

    private void FixedUpdate()
    {
        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = v;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            GameManager1.instance.IncreaseScore(10);
        }
    }

}
