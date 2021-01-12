using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective2_1Script : MonoBehaviour
{
    private string message = "When you feel ready jump and go on top of the dune near the red umbrella";
    private bool inZone = false;
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

    // Update is called once per frame
    void Update()
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
