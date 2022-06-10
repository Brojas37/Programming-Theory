using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private Text YourScore;
    [SerializeField]
    private Text HighScore;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver)
        {
            canvas.SetActive(true);
            YourScore.text = "Your Score: " + gameManager.score;
            if (gameManager.score > MainManager.Instance.LoadBestScore())
            {
                MainManager.Instance.SaveBestScore(gameManager.score);
            }
            HighScore.text = "High Score: " + MainManager.Instance.LoadBestScore();
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
}
