using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed = 10f;

    public bool onRoad = false;

    public float directie = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onRoad)
        {
            gameObject.transform.position += Vector3.forward * speed * directie;
        }
    }
}
