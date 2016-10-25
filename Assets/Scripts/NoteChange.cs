using UnityEngine;
using System.Collections;

public class NoteChange : MonoBehaviour {
    public GameObject notepaper;
    public Material[] materials;
    public Renderer rend;
    // Use this for initialization
    void Start ()
    {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        rend.material = materials[DestroyChest.score];
    }
}
