using UnityEngine;
using System.Collections;

public class DestroyText : MonoBehaviour {
    public static float score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chest")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Destroy(other.gameObject);
            score += 1;
        }
    }
}
