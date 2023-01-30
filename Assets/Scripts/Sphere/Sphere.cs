using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public ParticleSystem myParticleSphere;
    [SerializeField] GameObject explosiveSphere;
    [SerializeField] float explosionSphereDelay = 0.15f;

    private CinemachineImpulseSource impulseSourceSphere;

    private void Start()
    {
        impulseSourceSphere = GetComponent<CinemachineImpulseSource>();
        //myParticleSphere.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ExplodeSphere(collision));
        }
    }

    public IEnumerator ExplodeSphere(Collision collision)
    {
        yield return new WaitForSeconds(explosionSphereDelay);

        Explosion();
    }

    void Explosion()
    {
        Instantiate(myParticleSphere, transform.position, transform.rotation);
        gameObject.SetActive(false);
        impulseSourceSphere.GenerateImpulse(2);
    }
}
