﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective2_2Script : MonoBehaviour
{
    // Start is called before the first frame update
    private string message = "Press E when you are ready for the next level";
    private bool inZone = false;
    public CharacterController player;
    
    void Update()
    {
        if (inZone == true && Input.GetKey(KeyCode.E))
        {
            player.enabled = false;
            player.transform.position = new Vector3(-1340f, -20f, -2193f);
            player.enabled = true;
            inZone = false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inZone = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inZone = false;
        }
    }


    
    
    void OnGUI()
    {
        if (inZone)
        {
            GUI.Label(new Rect(Screen.width / 3f, Screen.height / 1.5f, 400f, 400f), message);
        }
    }
}
