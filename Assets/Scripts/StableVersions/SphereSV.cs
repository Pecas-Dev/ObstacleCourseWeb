//CODE THAT USES THE CHILD INSTED OF THE PREFAB (NOT USING INSTANTIATE)

/*using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour
{
    public ParticleSystem myParticleSphere;
    [SerializeField] GameObject explosiveSphere;
    [SerializeField] float explosionSphereDelay = 0.15f;

    private CinemachineImpulseSource impulseSourceSphere;

    private void Start()
    {
        impulseSourceSphere = GetComponent<CinemachineImpulseSource>();
        myParticleSphere.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ExplodeSphere(collision));
            Debug.Log("Que te den");
        }
    }

    public IEnumerator ExplodeSphere(Collision collision)
    {
        yield return new WaitForSeconds(explosionSphereDelay);
       
        myParticleSphere.gameObject.SetActive(true);
        impulseSourceSphere.GenerateImpulse(2);
        gameObject.SetActive(false);
    }
}*/
