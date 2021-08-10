using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    private float ScoreAmount;
    private float PointIncreasePerSecond;

    void Start()
    {
        ScoreAmount = 0f;
        PointIncreasePerSecond = 1f;
    }

    void Update()
    {
        ScoreText.text = (int)ScoreAmount + " : Score " ;

        ScoreAmount += PointIncreasePerSecond * Time.deltaTime;   
    }

}
