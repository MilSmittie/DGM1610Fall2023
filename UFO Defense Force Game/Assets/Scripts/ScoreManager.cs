using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //test mesh pro namespace added to access unity librarys for UI

public class ScoreManager : MonoBehaviour
{
    public int score; //keep score value
    public TextMeshProUGUI scoreText; //visual text element to be modified

    public void IncreaseScore(int amount) //tis method when called increases the score by predetermined amount
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}