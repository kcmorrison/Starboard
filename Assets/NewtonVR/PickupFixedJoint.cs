using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupFixedJoint : MonoBehaviour {

    public Rigidbody rigidBodyAttachPoint;

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    HingeJoint hinge;

    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate () {

        device = SteamVR_Controller.Input((int)trackedObj.index);
        //Touch
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("you are touching");
        }
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("you are touching trigger all the way down");
        }
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("you let it up");
        }

        //Press
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("you are pressing");
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            //GetComponent<Animation>().Play("bars");
            Debug.Log("you are pressing trigger all the way down");
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("you let press up");
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.name == "rudder")
        {
            Debug.Log("You have collided with " + col.name + " and activated OnTriggerStay");
            if (hinge == null && device.GetTouch(SteamVR_Controller.ButtonMask.Grip))
            {
                hinge = col.gameObject.AddComponent<HingeJoint>();
                hinge.connectedBody = rigidBodyAttachPoint;
            }
            else if (hinge != null && device.GetTouchUp(SteamVR_Controller.ButtonMask.Grip))
            {
                GameObject go = hinge.gameObject;
                Rigidbody rigidBody = go.GetComponent<Rigidbody>();
                Object.Destroy(hinge);
                hinge = null;

            }
        }
    }


}
