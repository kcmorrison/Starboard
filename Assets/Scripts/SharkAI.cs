using UnityEngine;
using System.Collections;

public class SharkAI : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed = 4;
    public float MaxDist = 10;
    public float MinDist = 5;
    public Rigidbody rb;




    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        //transform.LookAt(Player.transform.position);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            Quaternion oldRot = transform.rotation;
            transform.LookAt(Player.position);
            transform.rotation = Quaternion.Slerp(oldRot, transform.rotation, 0.5f);

            rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * MoveSpeed);


            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }

}