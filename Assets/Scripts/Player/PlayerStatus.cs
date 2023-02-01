using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] float deathDelay = 0.15f;
    [SerializeField] float timer = 0f;
    [SerializeField] GameObject deathUI;

    private bool isTriggered = false;
    public bool hasDied = false;

    int score = 0;

    MineExplosions explosion;
    Sphere sphereExplosion;

    private CinemachineImpulseSource impulseSource;

    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
        explosion = FindObjectOfType<MineExplosions>();
        sphereExplosion = FindObjectOfType<Sphere>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Explosive")
        {
            timer = 0f;

            score++;
            Debug.Log(score);

            isTriggered = true;
        }
        else if (collision.gameObject.tag == "ReduceWall")
        {
            score--;
            Debug.Log(score);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Explosive")
        {
            explosion.StopCoroutine("Explode");
            sphereExplosion.StopCoroutine("ExplodeSphere");
            isTriggered = false;
        }
    }


    private void Update()
    {
        if (isTriggered)
        {
            timer += Time.deltaTime;
            if (timer >= deathDelay)
            {
                isTriggered = false;
                impulseSource.GenerateImpulse(.5f);
                gameObject.SetActive(false);
                timer = 0f;
                deathUI.SetActive(true);
                hasDied= true;
            }
        }
    }
}
