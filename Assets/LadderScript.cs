using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    //public Transform playerController;

    private bool insideLadder;

    public float ladderHeight;

    public CharacterController playerController; 
    // Start is called before the first frame update
    void Start()
    {
        insideLadder = false;

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Ladder"))
        {
            
            //playerInput.enabled = true;
            insideLadder = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (insideLadder && Input.GetKey("w"))
        {
            playerController.Move(Vector3.up / ladderHeight);
            //playerController.transform.position += Vector3.up / ladderHeight;
        }
    }
}
