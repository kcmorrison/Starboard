using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{

    GravityAttractor sea;
    Rigidbody rigidBody;

    void Awake()
    {
        sea = GameObject.FindGameObjectWithTag("sea").GetComponent<GravityAttractor>();
        rigidBody = GetComponent<Rigidbody>();

        // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
        rigidBody.useGravity = false;
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Allow this body to be influenced by sea's gravity
        sea.Attract(rigidBody);
    }
}