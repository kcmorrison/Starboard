using UnityEngine;
using System.Collections;


public class ShipMovementRotation : MonoBehaviour
{


    public static float rotationSpeed = 10f;

    public Transform rudder;
    public Transform rudder2;



    void Update()
    {


        float step = rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rudder.rotation, step);


        //float rudderrotation = rudder.rotation.y - rudder2.rotation.y;

        //Debug.Log("Rudder rotation " + rudder.rotation.y + "");
        //transform.rotation = rudder.transform.rotation;
        //transform.rotation = Quaternion.Euler(0, rudderrotation, 0);
        //transform.Rotate(rudderrot, rotationSpeed * Time.deltaTime);



    }


}

