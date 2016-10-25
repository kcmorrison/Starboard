using UnityEngine;
using System.Collections;

public class DestroyChest : MonoBehaviour {

    public static int score = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chest")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Destroy(other.gameObject);
            score += 1;
            Debug.Log("Chest " + score + "");
        }
    }
}
