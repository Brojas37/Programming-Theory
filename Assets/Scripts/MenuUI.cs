using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MenuUI : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField]
    private Text highScore;

    private float bestScore;

    public void Start()
    {
        bestScore = MainManager.Instance.LoadBestScore();
        LoadHighScore();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadHighScore()
    {
        highScore.text = "High Score: " + bestScore;
    }
}
