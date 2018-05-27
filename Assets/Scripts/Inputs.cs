using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour {
	public Transform tf;
	private Movement movementDisable; // Get a reference to to my Movement and name it movementDisable



	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform> (); //calls transfrom component
		{
			movementDisable = GetComponent<Movement>(); //  hold the Movement script component
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			tf.position = Vector3.zero; //returns sprite to center of the world 
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			gameObject.SetActive (false); //sets game object to off
		} 
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();//cleanly extis the app 
		}
		if (Input.GetKeyDown (KeyCode.P)) // Check to see if P was pressed down & will toggle the movement for the shuttle on and off
		{
			movementDisable.enabled = !movementDisable.enabled; // Access script's enabled function and set it to On/Off
		}
	}
}
