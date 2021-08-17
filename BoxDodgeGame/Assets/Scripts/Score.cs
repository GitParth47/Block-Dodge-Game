using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    private float ScoreAmount;
    private float PointIncreasePerSecond;
    private float highScore = 0;
    public Text HighScoreText;



    internal void CalculateHighScore()
    {
        if(ScoreAmount > highScore)
        {
            highScore = ScoreAmount;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }
    }

    

    void Start()
    {
        ScoreAmount = 0f;
        PointIncreasePerSecond = 1f;
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        HighScoreText.text = highScore.ToString("0");

        
    }

    void Update()
    {
        ScoreText.text = (int)ScoreAmount + " : Score " ;

        ScoreAmount += PointIncreasePerSecond * Time.deltaTime;
    
        //PlayerPrefs.SetFloat("HighScore", ScoreAmount);
         
     }

   
}
