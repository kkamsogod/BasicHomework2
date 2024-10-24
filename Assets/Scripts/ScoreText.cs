using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
       if (scoreText == null)
        {
            scoreText = GetComponent<TextMeshProUGUI>();
        }     

        scoreButton.OnScoreChanged += RefreshUI;
    }

    void RefreshUI(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}