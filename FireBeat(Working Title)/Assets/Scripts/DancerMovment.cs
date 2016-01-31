using UnityEngine;
using System.Collections;

public class DancerMovment : MonoBehaviour {

	public float speed; //this will determine the speed of the object
	public Transform PromptPosition; //this is the positon where the dancers will go to for the pose
	public GameObject [] Dancers; // this will hold all of the dancers in the inspector
	public Transform [] Positions; // this will hold all of their places
	public bool DanceRotation = true; //this will tell the game if the circle is rotating or not

	// Use this for initialization
	void Start () 
	{	//all of this will make the dancers invisble and non usable at the start
		Dancers [0].SetActive(true);
		Dancers [1].SetActive(false);
		Dancers [2].SetActive(true);
		Dancers [3].SetActive(false);
		Dancers [4].SetActive(false);
		Dancers [5].SetActive(false);
		Dancers [6].SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
	{	//will move
		if (DanceRotation == true) 
		{
			transform.Rotate (new Vector3 (0, -90, 0) * Time.deltaTime);
		}
		//not move
		if (DanceRotation == false) 
		{
			transform.Rotate (new Vector3 (0, 0, 0) * Time.deltaTime);
		}
		DancerVisible (); //references the DancerVisible function
		TimePositions (); //references the TimePositions function
		print (GameController.Counter); //shows it in the console tab
	}

	void TimePositions()
	{	//Will do this inbetween this time
		if (Time.time >= 1.0517f && Time.time <= 2.0f) 
		{
			DanceRotation = false;
			Dancers [0].transform.position = Vector3.MoveTowards (transform.position, PromptPosition.position, speed);
			Debug.Log ("STOP");
		} 
		else //alternative or does not work
		{
			DanceRotation = true;
			Dancers [0].transform.position = Vector3.MoveTowards (transform.position, Positions[0].position, speed);
		}
	}

	void DancerVisible()
	{
		switch (GameController.Counter) 
		{
		case 3: //the cases are controlled by the counter variable ex: counter = 3 will go to case 3. 4, then case 4 etc.
			print("you have three");
			break;
		case 4:
			print ("you have four");
			Dancers [1].SetActive (true);
			break;
		case 5:
			print ("you have five");
			Dancers [5].SetActive (true);
			break;
		case 6:
			print ("you have six");
			Dancers [3].SetActive (true);
			break;
		case 7:
			print ("you have seven");
			Dancers [4].SetActive (true);
			break;
		}
	}
}
