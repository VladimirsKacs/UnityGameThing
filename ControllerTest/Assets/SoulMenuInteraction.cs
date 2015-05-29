using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoulMenuInteraction : MonoBehaviour {

	private bool soulMenuOn;
	// Use this for initialization
	void Start () {
		soulMenuOn = false;
	}	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			soulMenuOn = true;
		}

		if (soulMenuOn == true) {
			EnableSoulMenu ();
		}
	}

	void EnableSoulMenu () {
		//Time.timeScale = 0.1f;
		this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
	}
}
