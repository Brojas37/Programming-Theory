using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField]
    private Text HighScore;
    [SerializeField]
    private Text YourScore;
    [SerializeField]
    private Text TimeLeft;

    private float timer;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        timer = 100;
    }

    public void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimeLeft.text = "Time: " + Mathf.Round(timer);
        } else
        {
            gameManager.gameOver = true;
            TimeLeft.text = "Time: 0";
        }
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
