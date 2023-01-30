//OLD STABLE VERSION OF THE CODE (FOR POSSIBLE FUTURE MALFUNCTIONS, RETURN TO THIS CODE)


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] ParticleSystem myParticle;
    [SerializeField] GameObject pointWall;
    [SerializeField] float explosionDelay = 0.15f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(ExplosionDelay());
        }
    }

    IEnumerator ExplosionDelay()
    {
        yield return new WaitForSeconds(explosionDelay);
        myParticle.Play();
        pointWall.SetActive(false);

    }
}*/