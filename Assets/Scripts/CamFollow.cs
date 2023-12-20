using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform toFollow;
    public float xlimit = 5;
    
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 v = transform.position;
        if(toFollow.position.x - v.x > xlimit)
        {
            v.x = toFollow.position.x - xlimit;
        }
        else if (toFollow.position.x - v.x < xlimit)
        {
            v.x = toFollow.position.x + xlimit;
        }
        v.x = toFollow.transform.position.x;
        //v.y = toFollow.transform.position.y;
        transform.position = v;
        //transform.position = toFollow.transform.position;
    }
}
