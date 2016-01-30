using UnityEngine;
using System.Collections;

public class DancerMovment : MonoBehaviour {

	public float speed;
	public Transform PromptPosition;
	public GameObject [] Dancers;
	public Transform [] Positions;
	public bool DanceRotation = true;
	public float seconds;

	// Use this for initialization
	void Start () 
	{
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
	{
		if (DanceRotation == true) 
		{
			transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
		}

		if (DanceRotation == false) 
		{
			transform.Rotate (new Vector3 (0, 0, 0) * Time.deltaTime);
		}
		DancerVisible ();
		TimePositions ();
		print (GameController.Counter);
	}

	void TimePositions()
	{
		if (Time.time >= 1.01572f && Time.time <= 2.0f) 
		{
			DanceRotation = false;
			Dancers [0].transform.position = Vector3.MoveTowards (transform.position, PromptPosition.position, speed);
			Debug.Log ("STOP");
		} 
		else 
		{
			DanceRotation = true;
			Dancers [0].transform.position = Vector3.MoveTowards (transform.position, Positions[0].position, speed);
		}
	}

	void DancerVisible()
	{
		switch (GameController.Counter) 
		{
		case 3:
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
