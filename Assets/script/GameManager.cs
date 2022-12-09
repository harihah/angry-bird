using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Text scoreText;
    public GameObject panel;
    private int score;

    public void play()
    {
        score = 0;
        scoreText.text = score.ToString();

        panel.SetActive(false);
    }
    public void GameOver()
    {
        panel.SetActive(true);
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
