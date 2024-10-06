using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameManager gamePause;
    public GameObject gameOverCanvas;
    
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

