using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class RudderMovement : MonoBehaviour {

    public static float movementSpeed = -1.5f;

    void Update ()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;

   


        //Debug.Log("" + transform.eulerAngles + "");
        //Debug.Log("" + transform.eulerAngles + "");
    }

}

