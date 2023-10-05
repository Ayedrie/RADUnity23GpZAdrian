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

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }

    }

    internal void ImThrowingYou(GoatControl goatControl)
    {
        transform.position = goatControl.transform.position + 2* Vector3.up + 1 * goatControl.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 8 * (3 * Vector3.up + 7 * goatControl.transform.forward);


    }



}
