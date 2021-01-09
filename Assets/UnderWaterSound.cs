using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class UnderWaterSound : MonoBehaviour
{
    public AudioSource player;    
    public AudioSource splash;

    public ParticleSystem particleLauncher;
    void Start ()
    {
    }        
    
    void OnTriggerEnter(Collider other)
    {
        particleLauncher.transform.position = other.transform.position;
        

        if (other.CompareTag("Player") )
            player.Play ();
        splash.Play();
        particleLauncher.Emit(500);
    }
    
    void OnTriggerExit(Collider other)
    {
        player.Stop();

    }

}
