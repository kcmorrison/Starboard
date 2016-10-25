using UnityEngine;
using System.Collections;


public class BirdMovementStationary : MonoBehaviour
{
    public GameObject boat;

    void Update()
    {
        transform.LookAt(boat.transform);
        transform.Rotate(0, 90, 0);
    }

}

