using UnityEngine;
using System.Collections;



public class GameLoop : MonoBehaviour {

    float score = DestroyChest.score;
	float timer = 0.0f;
	bool gameON = true;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("high1"))
		{
			PlayerPrefs.SetFloat("high1", 0.0f);
		}

		if (PlayerPrefs.HasKey("high2"))
		{
			PlayerPrefs.SetFloat("high2", 0.0f);
		}

		if (PlayerPrefs.HasKey("high3"))
		{
			PlayerPrefs.SetFloat("high3", 0.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameON)
		{
			timer+=Time.deltaTime;
		}

        if (DestroyChest.score >= 1)
        {
            gameON = false;
            kill();
        }
	}

	public void kill()
	{
		gameON = false;
		Debug.Log("ded");

		if (PlayerPrefs.GetFloat("high1")==0.0f)
		{
			PlayerPrefs.SetFloat("high1", timer);
		}
		else if (PlayerPrefs.GetFloat("high1") > timer)
		{
			float tmp1 = PlayerPrefs.GetFloat("high1");
			float tmp2 = PlayerPrefs.GetFloat("high2");
			PlayerPrefs.SetFloat("high1", timer);
			PlayerPrefs.SetFloat("high2", tmp1);
			PlayerPrefs.SetFloat("high3", tmp2);
		}
		else if (PlayerPrefs.GetFloat("high2")==0.0f)
		{
			PlayerPrefs.SetFloat("high2", timer);
		}
		else if (PlayerPrefs.GetFloat("high2") > timer)
		{
			float tmp2 = PlayerPrefs.GetFloat("high2");
			PlayerPrefs.SetFloat("high2", timer);
			PlayerPrefs.SetFloat("high3", tmp2);
		}
		else if (PlayerPrefs.GetFloat("high3")==0.0f || PlayerPrefs.GetFloat("high3") > timer)
		{
			PlayerPrefs.SetFloat("high3", timer);
		}

		Debug.Log(PlayerPrefs.GetFloat("high1") + " high1");
		Debug.Log(PlayerPrefs.GetFloat("high2") + " high2");
		Debug.Log(PlayerPrefs.GetFloat("high3") + " high3");

        float timeStay = 0.0f;
        StartCoroutine(Example());
        Application.LoadLevel(1);


    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(30);
    }
}
