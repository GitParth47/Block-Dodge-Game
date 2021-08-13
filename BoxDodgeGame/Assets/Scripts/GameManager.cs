using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Score m_score = null;
    public void EndGame()
    {
        m_score.CalculateHighScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
