using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	public float horizontalSpeed;
	//distance from character's center to the floor to check if jumping is allowed
	public float soleHeight = 0.33f;
	//mask of jumping layer TODO: adjust so that monsters and traps are included
	private int layerMask = 1 << 8; 

	// Use this for initialization
	void Start () {

		horizontalSpeed = 3.5f;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("left")) {
			this.transform.position -= new Vector3(horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKey ("right"))
			this.transform.position += new Vector3(horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);

		if (Input.GetKeyDown ("up") && allowedToJump()) 
			this.GetComponent<Rigidbody2D>().AddForce (Vector2.up * 300);

		if (Input.GetKey("r")) {
			Application.LoadLevel("ControllerTest");
		}
	}

	bool allowedToJump() {
		// checking if the first object beneath character's feet is in the floor layer
		if (Physics2D.Raycast (transform.position, -Vector3.up, soleHeight, layerMask)) {
			return true;
		}
		else {
			return false;
		}
	} 
}
