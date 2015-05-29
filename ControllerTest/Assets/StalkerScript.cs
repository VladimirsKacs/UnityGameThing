using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StalkerScript : MonoBehaviour {
	
	private Renderer alpha;
	private float alphaopacity = 100;

	// Use this for initialization
	void Start () {
		alpha = GetComponent<Renderer>();
		Debug.Log(alpha);
	}
	
	// Update is called once per frame
	void Update () {
			Debug.Log ("Alpha on start:" + alpha.material.color.a);
		if (Input.GetKey ("space")) {
			Debug.Log("down");

			Color color = alpha.material.color;
			color.a = alphaopacity;
			alpha.material.color = color;

			Debug.Log("Alpha after button:" + alpha.material.color.a);

		} else {
			Debug.Log("up");
		}
	}
}
