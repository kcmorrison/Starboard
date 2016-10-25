using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class BirdMovement : MonoBehaviour {

    public static float movementSpeed = 4f;

    void Update ()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

}

