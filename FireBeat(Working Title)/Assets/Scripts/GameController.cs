using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Transform [] SpawnPositions;
	public bool [] LV1Progression;
	public bool [] HasPlayed;
	public GameObject DanceCircle;
	public AudioClip[] BGM;
	public AudioClip NegativeSound;
	public GameObject Dancer;
	public static int Counter;

	AudioSource audio;

	// Use this for initialization
	void Start () 
	{
		Counter = 3;
		audio = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Counter > 7) 
		{
			Counter = 7;
		}

		LV1 ();
	}

	void LV1()
	{
		if (Time.time >= 1.01572f && Time.time <= 2.0f && Input.GetMouseButtonDown (0)) 
		{
			Debug.Log ("HIT");
			LV1Progression [0] = true;
		} 
		else if (Time.time > 3.0f && LV1Progression [0] == false)
		{
			if (HasPlayed[0] == false) 
			{
				audio.PlayOneShot (NegativeSound, 0.7F);
				HasPlayed[0] = true;
			}
		}
	}
}
