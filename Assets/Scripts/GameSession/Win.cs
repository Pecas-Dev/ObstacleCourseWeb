using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public bool hasWin = false;

    [SerializeField] GameObject winUI;

    Move playerMove;

    void Awake()
    {
        playerMove = FindObjectOfType<Move>();
    }

    void Start()
    {
        winUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Winner();
    }

    void Winner()
    {
        winUI.SetActive(true);
        playerMove.moveSpeed = 0f;
        hasWin= true;
    }

}

