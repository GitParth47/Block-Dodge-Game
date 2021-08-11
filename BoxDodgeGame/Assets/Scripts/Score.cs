using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    private float ScoreAmount;
    private float PointIncreasePerSecond;
    public Text HighScoreText;

    void Start()
    {
        ScoreAmount = 0f;
        PointIncreasePerSecond = 1f;

        HighScoreText.text = PlayerPrefs.GetFloat("HighScore",0).ToString("0");

        
    }

    void Update()
    {
        ScoreText.text = (int)ScoreAmount + " : Score " ;

        ScoreAmount += PointIncreasePerSecond * Time.deltaTime;
    
        PlayerPrefs.SetFloat("HighScore", ScoreAmount);
         
     }

   
}
