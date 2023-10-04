using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballcontrolscript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(GoatControl goatControl)
    {
        transform.position = goatControl.transform.position + 2* Vector3.up + 3 * goatControl.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 10 * (2 * Vector3.up + 3 * goatControl.transform.forward);


    }



}
