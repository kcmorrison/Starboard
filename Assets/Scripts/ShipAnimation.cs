using UnityEngine;
using System.Collections;


public class ShipAnimation : MonoBehaviour {


    public Animation anim;

    void Update()
    {

        //if (ShipMovement.movementSpeed == 0)
        //{
        //    anim = GetComponent<Animation>();
        //    print("frame " + anim["Take 001"].time + "");
        //    anim["Take 001"].time = 1.6f;
        //    anim["Take 001"].speed = 0f;
        //}

        //else if (ShipMovement.movementSpeed > 0 && anim["Take 001"].time > 1f)
        //{
        //    anim = GetComponent<Animation>();
        //    print("frame " + anim["Take 001"].time + "");
        //    anim["Take 001"].time -= .01f;
        //    anim["Take 001"].speed = 0f;
        //}

        //else if (ShipMovement.movementSpeed > 0 && anim["Take 001"].time == 1.000001f)
        //{
        //    anim = GetComponent<Animation>();
        //    print("frame " + anim["Take 001"].time + "");
        //    anim["Take 001"].time = 0.1f;
        //    anim["Take 001"].speed = 0f;
        //}

        //else if (ShipMovement.movementSpeed > 0 && anim["Take 001"].time > 0f && anim["Take 001"].time < .91f)
        //{
        //    anim = GetComponent<Animation>();
        //    print("frame " + anim["Take 001"].time + "");
        //    anim["Take 001"].time += .005f;
        //    anim["Take 001"].speed = 0f;
        //}

        //else if (ShipMovement.movementSpeed > 0 && anim["Take 001"].time == 0.9099993f && anim["Take 001"].time != 0.1f)
        //{
        //    anim = GetComponent<Animation>();
        //    print("frame " + anim["Take 001"].time + "");
        //    anim["Take 001"].time = 0.1f;
        //    anim["Take 001"].speed = 0f;
        //}


        if (ShipMovement.movementSpeed == 0)
        {
            anim = GetComponent<Animation>();
            print("frame " + anim["Take 001"].time + "");
            anim["Take 001"].time = 1.6f;
            anim["Take 001"].speed = 0f;
        }

        if (ShipMovement.movementSpeed > 0)
        {
            anim = GetComponent<Animation>();
            print("frame " + anim["Take 001"].time + "");
            anim["Take 001"].time -= .004f;
            anim["Take 001"].speed = 0f;
            if (anim["Take 001"].time <= 0f)
            {
                anim = GetComponent<Animation>();
                print("frame " + anim["Take 001"].time + "");
                anim["Take 001"].time = .91f;
            }
        }


    }

}

