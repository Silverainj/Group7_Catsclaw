using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Trigger : MonoBehaviour
{

    public GameObject enemy;
    //public Enemy_Behavior enemy;
    
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        enemy.SetActive(true);
        //enemy.moving(true);

    }

}
