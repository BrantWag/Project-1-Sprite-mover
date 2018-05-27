using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public Transform tf;
	public float speed;
	private GameObject spaceship;
	// Use this for initialization
	void Start () 	{
		tf = GetComponent<Transform> (); //calls transfrom component
		spaceship = GetComponent<GameObject>();//sets game object to true 
		//spaceship = GetComponent();
	}

	// Update is called once per frame
	void Update ()
	{
		tf.position = tf.position + Vector3.zero;// Puts sprite in center of world 
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.RightArrow)) {
			tf.position = tf.position + Vector3.right * .05f; //Moves Sprite one unit right
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			tf.position = tf.position + Vector3.right;//moves sprite right
		}
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.LeftArrow)) {
			tf.position = tf.position + Vector3.left * .05f; //Moves Sprite one unit left
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			tf.position = tf.position + Vector3.left;//moves sprite left
		}
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.DownArrow)) {
			tf.position = tf.position + Vector3.down * .05f; //Moves Sprite one unit down
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			tf.position = tf.position + Vector3.down;//moves sprite down
		}
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.UpArrow)) {
			tf.position = tf.position + Vector3.up * .05f; //Moves Sprite one unit 
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			tf.position = tf.position + Vector3.up; //moves sprite up
		}
 
	}
}