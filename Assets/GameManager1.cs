using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI timeTxt;

    int score = 0;
    float time = 90;

    public static GameManager1 instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeTxt.text = "Time: " + time.ToString("00.0");
        if (Input.GetButtonDown("Fire1"))
            IncreaseScore(10);
        if (Input.GetButtonDown("Fire2"))
            IncreaseScore(15);
    }

    public void IncreaseScore(int inc)
    {
        score += inc;
        scoreTxt.text = "Score: " + score;
    }
}
