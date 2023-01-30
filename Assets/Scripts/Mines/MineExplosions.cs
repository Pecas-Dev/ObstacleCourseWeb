using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosions : MonoBehaviour
{
    [SerializeField] ParticleSystem myParticle;
    [SerializeField] GameObject explosiveMine;
    [SerializeField] float explosionDelay = 0.15f;

    private CinemachineImpulseSource impulseSource;

    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Explode(collision));
        }
    }

    private IEnumerator Explode(Collision collision)
    {
        yield return new WaitForSeconds(explosionDelay);

        MineExplosion();
    }

    void MineExplosion()
    {
        myParticle.Play();
        gameObject.SetActive(false);
        impulseSource.GenerateImpulse(1);
    }
}
