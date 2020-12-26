using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int currentScore;
    public int highScore;
    [SerializeField] private TMP_Text currentScoreText;
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High score: " + highScore;
    }

    private void Update()
    {
        currentScoreText.text = currentScore.ToString();
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High score: " + highScore;
        }
    }
}
