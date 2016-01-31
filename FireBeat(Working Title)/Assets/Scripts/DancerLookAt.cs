using UnityEngine;
using System.Collections;

public class DancerLookAt : MonoBehaviour {

	public Transform Center; // the position of the object

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (transform.position + Center.transform.position); //this will make the objects look athe center object
	}
}
