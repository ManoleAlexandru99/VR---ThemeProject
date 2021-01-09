using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBall : MonoBehaviour
{

    public Transform theDest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<SphereCollider>().enabled = false;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Carry").transform;
        
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<SphereCollider>().enabled = true;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

