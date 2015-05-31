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
		//horizontalSpeed = 0;
		horizontalSpeed = 3.5f;
		Debug.Log (Time.deltaTime);
		Debug.Log (Time.fixedDeltaTime);
		//Time.timeScale = 0.1f;
		Debug.Log (Time.deltaTime);
		Debug.Log (Time.fixedDeltaTime);
		//Time.fixedDeltaTime *= 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.deltaTime);

		if (Input.GetKey ("left") || (Input.GetAxis ("Horizontal") < 0)) {
			Debug.Log("LEFT");
			this.transform.position -= new Vector3 (horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKey ("right")||(Input.GetAxis("Horizontal")>0))
			this.transform.position += new Vector3(horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);

		if (Input.GetKeyDown ("up") && allowedToJump()) 
			this.GetComponent<Rigidbody2D>().AddForce (Vector2.up * 300);

		if (Input.GetButtonDown ("OpenMenu"))
			Debug.Log ("UseSOuls");
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
