using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective1Script : MonoBehaviour
{
    private string message = "When you feel ready bring 2 boxes and climb on them";
    private bool inZone = false;
    public CharacterController player;
    // Start is called before the first frame update
    void Start()
    {
        
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

    private void Update()
    {
        
    }


    void OnGUI()
    {
        if (inZone)
        {
            GUI.Label(new Rect(Screen.width / 3f, Screen.height / 1.5f, 400f, 400f), message);
        }
    }
}