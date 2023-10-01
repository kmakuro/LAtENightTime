using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the UI Text element displaying the score
    public int score = 0; // The player's score
    public string sceneToload;

    void Start()
    {
        // Initialize the score text
        UpdateScoreText();
    }

    // Method to update the score
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Method to update the score text in the UI
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
        
    }

    private void Update()
    {
        if (score > 100)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}