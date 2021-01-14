using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public Transform bottom;

    public Transform top;

    public float smooth;
    
    private Vector3  newPos;

    enum ElevatorStates
    {
        goUp,
        goDown,
        pause
    };

    private ElevatorStates state;

    private ElevatorStates previous;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        state = ElevatorStates.pause;
        previous = ElevatorStates.goDown;
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(ChangeState());
        ChangeState();
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = null;
        }
    }

    void  ChangeState()
    {
        //yield return new WaitForSeconds(6);
        if (state == ElevatorStates.goDown)
        {
            newPos = bottom.position;
            transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
            /*
            if(transform.position == newPos)
                state = ElevatorStates.pause;
                */
            //state = ElevatorStates.pause;
            if (transform.position.y > -21 && transform.position.y < -20) //Am ajuns jos
            {
                state = ElevatorStates.pause;
            }
        }
        
        else if (state == ElevatorStates.goUp)
        {
            newPos = top.position;
            transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
            if (transform.position.y > 68 && transform.position.y < 69) //Am ajuns sus
            {
                state = ElevatorStates.pause;
            }
            
            //state = ElevatorStates.pause;
        }

        else if (state == ElevatorStates.pause)
        {
            if (previous == ElevatorStates.goDown)
            {
                state = ElevatorStates.goUp;
                previous = ElevatorStates.goUp;
            }
            else
             {
                 state = ElevatorStates.goDown;
                 previous = ElevatorStates.goDown;
             }
        }
    }
}
