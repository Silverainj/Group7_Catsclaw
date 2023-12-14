using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attacking : MonoBehaviour
{
    public float speed = 3;
    public float attackSpeed = 5;
    public float limit = 4;
    public Transform aelia;

    enum State {patrol, attack}
    State myState = State.patrol;
    void Update()
    {
        switch (myState)
        {
            case State.patrol:
                transform.Translate(0, speed * Time.deltaTime, 0);
                if (transform.position.y > limit && speed > 0)
                {
                    speed = -speed;
                }
                if (transform.position.y < -limit && speed < 0)
                {
                    speed = -speed;
                }
                if (Vector3.Distance(transform.position, aelia.position) <8)
                {
                    myState = State.attack;
                }
                break;
            case State.attack:
                transform.position =
                    Vector3.MoveTowards(transform.position,
                        aelia.position, attackSpeed * Time.deltaTime);
                if (Vector3.Distance(transform.position, aelia.position) > 8)
                {
                    myState = State.patrol;
                }
                break;
        }
        
        
    }
}
