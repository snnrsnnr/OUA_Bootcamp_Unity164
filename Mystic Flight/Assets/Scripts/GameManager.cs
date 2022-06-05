using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    

    public int score;
    public int highScore;

    public Text ScoreText;

    public Text HighScore;

    
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");
        HighScore.text = highScore.ToString();

        ScoreText.text = score.ToString();
       
        
    }
    
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();

        if (score > highScore)
        {
            highScore = score;
            HighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Debug.Log("Oyundan Çýktýk");
        Application.Quit();
    }


}