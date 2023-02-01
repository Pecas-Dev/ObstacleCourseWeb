using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool isPaused = false;

    [SerializeField] GameObject pauseUI;

    Beginning gameBegin;
    Win gameWin;
    PlayerStatus playerDeath;

    void Start()
    {
        gameBegin = FindObjectOfType<Beginning>();
        gameWin = FindObjectOfType<Win>();
        playerDeath = FindObjectOfType<PlayerStatus>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameBegin.hasStarted && !gameWin.hasWin && !playerDeath.hasDied)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
