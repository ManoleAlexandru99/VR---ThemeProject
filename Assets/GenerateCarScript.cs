using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCarScript : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    
    // Start is called before the first frame update
    void Start()
    {
        car = car1;
    }

    private GameObject car ;
    private float nextActionTime = 0.0f;
    public float period = 2f;

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            int rand = Random.Range(0, 9);
            if (rand >= 2 && rand <= 5)
            {
                car = car1;
            }

            if (rand >= 6 && rand < 9)
            {
                car = car2;
            }

            if (rand == 9)
            {
                car = car3;
            }
            GameObject clone = Instantiate(car, transform.position, transform.rotation);
        }
    }
}
