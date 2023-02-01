using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float xRotation = 0f;
    [SerializeField] float yRotation = 1.5f;
    [SerializeField] float zRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation * Time.timeScale, zRotation);
    }
}
