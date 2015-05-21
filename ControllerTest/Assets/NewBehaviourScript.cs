using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float horizontalSpeed;
	public bool canJump;

	// Use this for initialization
	void Start () {
		horizontalSpeed = 0;
		Debug.Log ("start");
		foreach (var collider in this.GetComponents<BoxCollider2D>())
			Debug.Log ("collider: "+collider.name);
	}

	private bool onTheFloor()
	{
		Debug.Log ("is it on the floor?");
		Debug.Log(transform.position);
		var renderer = this.GetComponent<Renderer> ();
		float semiHeight = renderer.bounds.extents.x;
		RaycastHit2D hit = Physics2D.Raycast (transform.position-Vector3.up*(semiHeight+0.001f), -Vector3.up, 10);
		Debug.Log(hit.collider.name+"@"+hit.point+" ("+ hit.distance+" )");
		if (hit.distance<0.1) {
			Debug.Log ("yup.");
			return true;
		}
		return false;
	}

	// Update is called once per frame
	void Update () {
		horizontalSpeed *= 0.75f;
		if (Input.GetKey ("left"))
			horizontalSpeed -= 0.05f; 
		if (Input.GetKey ("right"))
			horizontalSpeed += 0.05f;
		if (Input.GetKeyDown ("up")&&onTheFloor()) 
			this.GetComponent<Rigidbody2D>().AddForce (Vector2.up * 300);
		this.transform.Translate (Vector3.right * horizontalSpeed);

		//OnCollisionEnter (null);
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("collision!");
		canJump = true;		
	}

	void OnCollisionEnxit(Collision collision) {
		Debug.Log ("No collision!");
		canJump = false;		
	}



}
