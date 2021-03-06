using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;

    void Awake()
    {
        //Calculate the range between the camera's position and the Bird's position
        range = transform.position - birdTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make the camera follow the Bird's movement on the X axis 
        //And keep the y position constant 
        transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
    }
}
