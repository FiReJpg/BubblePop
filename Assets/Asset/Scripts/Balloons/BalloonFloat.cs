using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFloat : MonoBehaviour
{

    public float floatSpeed = 1f;    // The speed at which the object floats
    public float floatHeight = 1f;   // The maximum height the object reaches
    public float floatFrequency = 1f; // The frequency of the floating motion

    private float startY;   // The initial y position of the object

    private void Start()
    {
        startY = transform.position.y;
    }

    private void Update()
    {
        // Calculate the new y position using a sine wave
        float newY = startY + Mathf.Sin(Time.time * floatFrequency) * floatHeight;

        // Move the object vertically
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Rotate the object to create a spinning effect (optional)
        //transform.Rotate(Vector3.up, floatSpeed * Time.deltaTime);
    }

}
