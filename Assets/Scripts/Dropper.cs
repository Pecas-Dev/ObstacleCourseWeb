using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] static float timeToDrop = 3f;

    public float timerDrop = 0f;

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timerDrop += Time.deltaTime;
        if(timerDrop >= timeToDrop)
        {
            rigidBody.useGravity= true;
            timerDrop = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Player")
        {
            rigidBody.isKinematic= true;
        }
    }
}
