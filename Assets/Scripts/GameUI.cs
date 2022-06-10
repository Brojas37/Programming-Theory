using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text HighScore;
    public Text YourScore;

    public GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void StartGame()
    {
        HighScore.text = "High Score: " + MainManager.Instance.LoadBestScore();
        UpdateYourScore();
    }

    public void UpdateYourScore()
    {
        YourScore.text = "Your Score: " + gameManager.score;
    }
}
