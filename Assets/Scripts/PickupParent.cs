using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupParent : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public static bool LeftIsPressed;
    public static bool RightIsPressed;


    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate () {

        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have collided with while holding down Touch");
            //ShipMovement.movementSpeed += .01f;
        }
        else
        {
            Debug.Log("You have collided with while holding down Touch");
            //ShipMovement.movementSpeed -= .01f;
        }

    }

    void OnTriggerStay(Collider col)
    {
       
        
            Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay");
            if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && col.tag == "Chest")
            {
                Debug.Log("You have collided with " + col.name + " while holding down Touch");
                col.attachedRigidbody.isKinematic = true;
                col.gameObject.transform.SetParent(gameObject.transform);
            }
            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) && col.tag == "Chest")
            {
                Debug.Log("You have collided with " + col.name + " while holding down Touch");
                col.gameObject.transform.SetParent(null);
                col.attachedRigidbody.isKinematic = false;

            }
        
    }

}
