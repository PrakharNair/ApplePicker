using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

	public static float botY = -20f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < botY) {
			Destroy (this.gameObject);

			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

			//call destroyed method
			apScript.AppleDestroyed();
		}
	}
}
