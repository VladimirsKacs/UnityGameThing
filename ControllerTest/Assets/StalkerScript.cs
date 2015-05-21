using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StalkerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKey ("space")) {
			Debug.Log("down");
			var player = GameObject.FindWithTag ("Player");
			var centerOfPlayer = player.transform.position;//+Vector3.up*327+Vector3.right*168;
			transform.position = centerOfPlayer;
			GetComponentInChildren<Image>().enabled=true;
		} else {
			Debug.Log("up");
			var img=GetComponentInChildren<Image>().enabled=false;
		}
		*/
		bool down = Input.GetKeyDown("space");
		bool held = Input.GetKey("space");
		bool up = Input.GetKeyUp("space");
	
		Debug.Log("Now: " + down + ", " + held + ", " + up);
	}
}
