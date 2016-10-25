using UnityEngine;
using System.Collections;


public class ShipMovement : MonoBehaviour {

    public static float movementSpeed = 0f;
    public static float rotationSpeed = .1f;

    public Transform player;
    public Transform rudder;
    public Transform lever;



    void Update()
    {

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.position += transform.forward * Time.deltaTime * movementSpeed;

        //Movement Speed
        if (lever.transform.localEulerAngles.x > 2f && lever.transform.localEulerAngles.x < 10f && movementSpeed < 8f)
        {
            print("Test Worked");
            movementSpeed += Time.deltaTime * 1f;
        }
        else if (lever.transform.localEulerAngles.x > 0f && lever.transform.localEulerAngles.x < 2f && movementSpeed != 0 && movementSpeed > 0)
        {
            movementSpeed -= .5f;
        }
        else if (movementSpeed < 0)
        {
            movementSpeed = 0f;
        }

        //Rotation
        if ((rudder.transform.localEulerAngles.y > 11f && rudder.transform.localEulerAngles.y < 30f && rotationSpeed < 30f) || (rudder.transform.localEulerAngles.y > 350f && rudder.transform.localEulerAngles.y < 359f && rotationSpeed < 0 && rotationSpeed != 0) || (rudder.transform.localEulerAngles.y > 1f && rudder.transform.localEulerAngles.y < 10f && rotationSpeed < 0 && rotationSpeed != 0))
        {
            print("Moving Right");
            rotationSpeed += 1f;
        }

        else if ((rudder.transform.localEulerAngles.y > 330f && rudder.transform.localEulerAngles.y < 349f && rotationSpeed > -30) || (rudder.transform.localEulerAngles.y > 1f && rudder.transform.localEulerAngles.y < 10f && rotationSpeed > 0 && rotationSpeed != 0) || (rudder.transform.localEulerAngles.y > 350f && rudder.transform.localEulerAngles.y < 359f && rotationSpeed < 0 && rotationSpeed != 0))
        {
            print("Moving left");
            rotationSpeed -= 1f;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rocks")
        {
            movementSpeed = 0f;

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

}

