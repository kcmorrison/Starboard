using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GravityBodySeaFloor : MonoBehaviour
{

    GravityAttractorSeaFloor seafloor;
    Rigidbody rigidBody;

    void Awake()
    {
        seafloor = GameObject.FindGameObjectWithTag("seafloor").GetComponent<GravityAttractorSeaFloor>();
        rigidBody = GetComponent<Rigidbody>();

        // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
        rigidBody.useGravity = false;
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Allow this body to be influenced by sea's gravity
        seafloor.Attract(rigidBody);
    }
}