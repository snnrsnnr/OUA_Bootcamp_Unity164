using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.ScoreText;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text ScoreText;

    void Start()
    {
        score = 0;
        ScoreText = score.ToString();
    }

    
    void Update()
    {
        
    }
   public void UpdateScore()
    {
        score++;
        ScoreText = score.ToString();

    }

   
}