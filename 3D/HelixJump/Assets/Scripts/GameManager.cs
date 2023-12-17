using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int bestScore;
    public int currentScore;

    public int currentLevel = 0;

    public static GameManager singleton;

    // Verifica que no exista mas de un GameManager
    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this) { 
        Destroy(gameObject);
        }

        bestScore = PlayerPrefs.GetInt("HighScore");
    }

    public void NextLevel()
    {
        Debug.Log("Siguiente nivel");
    }

    public void RestartLevel()
    {
        Debug.Log("Restart Level");
        singleton.currentScore = 0;
        FindObjectOfType<BallController>().ResetBall();
    }

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;

        if (currentScore >= bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("HighScore", currentScore); // PLayerPrefs guarda el dato del puntaje
        }
    }

}
