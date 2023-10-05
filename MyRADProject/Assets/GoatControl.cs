using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class GoatControl : MonoBehaviour
{
    public GameObject snowballCloneTemplate;

    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    private float turningSpeed = 180;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;
     
    }

    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(KeyCode.W))
    {
        transform.position += currentSpeed * transform.forward * Time.deltaTime;
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
            transform.position -= currentSpeed * transform.forward * Time.deltaTime;
    }


    if (Input.GetKeyDown(KeyCode.D))
    {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }

    if (Input.GetKeyDown(KeyCode.A))
    {
        transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
    }

    if (Input.GetMouseButton(0))
    {
       GameObject newGO = Instantiate(snowballCloneTemplate);

       snowballcontrolscript mySnowball = newGO.GetComponent<snowballcontrolscript>();

            mySnowball.ImThrowingYou(this);
    }
}
}
