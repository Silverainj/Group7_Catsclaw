using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Control : MonoBehaviour
{
    public float limit = 4;
    public float speed = 5;
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (transform.position.y > limit && speed > 0)
        {
            speed = -speed;
        }
        if (transform.position.y < -limit && speed < 0)
        {
            speed = -speed;
        }
    }
}
