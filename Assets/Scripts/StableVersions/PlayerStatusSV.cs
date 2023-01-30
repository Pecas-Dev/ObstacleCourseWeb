//OLD STABLE VERSION OF THE CODE (FOR POSSIBLE FUTURE MALFUNCTIONS, RETURN TO THIS CODE)

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Score : MonoBehaviour
{
    [SerializeField] float explosionDelay = 0.15f;

    int score = 0;

    private CinemachineImpulseSource _myImpulseSource;

    void Awake()
    {
        _myImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PointWall")
        {
            score++;
            Debug.Log(score);
            StartCoroutine(DestroyPlayer());

        }
        else if(collision.gameObject.tag == "ReduceWall")
        {
            score--;
            Debug.Log(score);
        }

    }

    void OnCollisionExit(Collision collision)
    {
        gameObject.SetActive(true);
    }

    IEnumerator DestroyPlayer() 
    {
        yield return new WaitForSeconds(explosionDelay);
        gameObject.SetActive(false);
        _myImpulseSource.GenerateImpulse(1);
    }
}*/
