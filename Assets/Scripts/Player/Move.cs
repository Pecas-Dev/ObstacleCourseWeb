using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField][Range(1f, 10f)] float moveSpeed = 10f;
    float reduceSpeed = 5f;

    float xValue;
    float zValue;

    Rigidbody playerRigidBody;

    void Awake()
    {
        
    }

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        //PlayerInput();
        MovePlayer();
    }

    void MovePlayer()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        Vector3 playerVelocity = new Vector3(xValue * moveSpeed, 0, zValue*moveSpeed);
        playerRigidBody.velocity = playerVelocity;
    }

    /*|void PlayerInput()
    {
        
    }*/

   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Explosive")
        {
            moveSpeed = reduceSpeed;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Explosive")
        {
            moveSpeed = 10f;
        }
    }

}
