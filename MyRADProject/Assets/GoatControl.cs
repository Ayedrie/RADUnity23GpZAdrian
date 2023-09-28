using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class GoatControl : MonoBehaviour
{
    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed = 2;, runningSpeed = 4;
        private float turningSpeed = 180;
    }

    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(KeyCode.W))
    {
        Transform.position += currentSpeed * transform.forward = Time.deltaTime;
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
        Transform.position -= currentSpeed * Transform.forward = Time.deltaTime;
    }


    if (Input.GetKeyDown(KeyCode.D))
    {
        Transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
    }

    if (Input.GetKeyDown(KeyCode.A))
    {
        Transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
    }


}
