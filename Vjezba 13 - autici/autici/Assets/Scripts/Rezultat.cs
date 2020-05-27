using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rezultat : MonoBehaviour
{
    public Text scoreText;
    int score;
    bool GameOver;

    private void Start()
    {
        GameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void scoreUpdate()
    {
        if (GameOver == false)
        {
            score += 1;
        }
    }

    public void GameOverActivated()
    {
        GameOver = true;
    }
}
