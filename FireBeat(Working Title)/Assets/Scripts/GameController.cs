using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Transform [] SpawnPositions;// this is for the dancer positions
	public bool [] LV1Progression; // this is to make sure the system knows that the players progressing
	public bool [] HasPlayed; //To make sure that certain notes have been played
	public float [] BeatStartTime; //recored seconds in the inpector for the negative sounds
	public GameObject DanceCircle; //holding the empty game object holding the dancers
	public AudioClip[] BGM; //for the background music
	public AudioClip NegativeSound; //Sound when the player messes up
	public GameObject Dancer; //where the dancer is held
	public static int Counter; //Holds the number of dancers

	AudioSource audio; //used to get the component (down in the start function

	// Use this for initialization
	void Start () 
	{
		Counter = 3;
		audio = GetComponent<AudioSource> (); // gets the audiosource component in the editor
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Counter > 7) //will be at seven no matter how high it gets
		{
			Counter = 7;
		}

		LV1 (); // call the LV1 function below
	}

	void LV1()
	{	//beat 1, if between these bits in time, and the left mouse button will do this
		if (Time.time >= BeatStartTime[0] && Time.time <= 2.0f && Input.GetMouseButtonDown (0))
		{
			Debug.Log ("HIT"); // for debugging purposes
			LV1Progression [0] = true; // will move on to the next one
		} 
		else if (Time.time > BeatStartTime[1] && LV1Progression [0] == false) // the next alternative when it does not 
		{
			if (HasPlayed[0] == false) //the if statement will makesure that it happens once 
			{
				audio.PlayOneShot (NegativeSound, 0.7F); //will play the sound
				HasPlayed[0] = true; //this will switch and make sure that it'll play once
			}
		}
	}
}
