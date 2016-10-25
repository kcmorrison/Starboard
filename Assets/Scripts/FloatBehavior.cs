using UnityEngine;
using System;
using System.Collections;

public class FloatBehavior : MonoBehaviour
{
    float originalx;

    public float floatStrength = 1f; // You can change this in the Unity Editor to 
                                    // change the range of y positions that are possible.

    void Start()
    {
        this.originalx = this.transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(originalx + ((float)Math.Sin(Time.time) * floatStrength), transform.position.y,
            transform.position.z);
    }
}