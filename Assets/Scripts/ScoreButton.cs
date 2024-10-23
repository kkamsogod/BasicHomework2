using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Action<int> OnScoreChanged;

    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }
}