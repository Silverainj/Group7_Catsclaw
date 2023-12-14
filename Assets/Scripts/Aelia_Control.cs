using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aelia_Control : MonoBehaviour
{
  
    public float speed = 10;
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime,
            0);
    }
}
