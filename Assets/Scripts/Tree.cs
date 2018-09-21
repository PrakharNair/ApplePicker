using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {
	// declare fields
	//prefab

	public GameObject applePrefab;

	//speed in meters/second
	public float speed = 1f;

	//distance when tree turns
	public float turn = 10f;

	//odds of tree changing directions
	public float changeOdds = 0.1f;

	//rate of apples
	public float appleRate = 1f; 

	// Use this for initialization
	void Start () {
		InvokeRepeating("dropApple", 1f, appleRate);
	}

	void dropApple() {
		GameObject apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;

		//move
		transform.position = pos;
		
		//moves left / right
		if(pos.x <  -turn)  {
			speed = Mathf.Abs(speed);
		}
		else if (pos.x > turn) {
			speed = -Mathf.Abs(speed);
		}
	}
	void FixedUpdate() {
		if(Random.value < changeOdds) {
			speed *= -1; 
		}
	}
}
