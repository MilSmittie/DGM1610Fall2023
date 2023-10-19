using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if (isGameOver == true)
        {
            EndGame(); //start endgame
        }
        else if (isGameOver == false)
        {
            gameOverText.gameObject.SetActive(false); //keep UI text game over hidden
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //reveal endgame
        Time.timeScale = 0; //freeze time
    }
}
