using UnityEngine;
using System.Collections;

public class CloudRotation : MonoBehaviour {

    public float movementSpeed = .5f;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.right * (movementSpeed * Time.deltaTime));
    }
}
