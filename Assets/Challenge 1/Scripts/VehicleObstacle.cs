using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleObstacle : MonoBehaviour
{
    // Private variable for the vehicle's speed
    private float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
