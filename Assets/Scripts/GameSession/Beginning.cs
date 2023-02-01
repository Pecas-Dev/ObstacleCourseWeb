using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Beginning : MonoBehaviour
{
    public bool hasStarted = false;

    public GameObject beginUI;

    Pause gamePause;

    void Awake()
    {
        gamePause = FindObjectOfType<Pause>();
    }

    void Start()
    {
        beginUI.SetActive(true);
        Time.timeScale = 0f;
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !gamePause.isPaused)
        {
            hasStarted = true;
            Time.timeScale = 1f;
            Destroy(beginUI);
        }
    }

}
