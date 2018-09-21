using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

	public TextMesh scoreGT; 
	// Use this for initialization
	void Start () {
		GameObject scoreGO = GameObject.Find("ScoreCounter");

		scoreGT = scoreGO.GetComponent<TextMesh>();

		scoreGT.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos2D = Input.mousePosition;

		
		mousePos2D.z = -Camera.main.transform.position.z;

		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;

	}

	void OnCollisionEnter(Collision coll) {

		GameObject collided = coll.gameObject;

		if(collided.tag == "Apple") {
			Destroy(collided);

			//parse score
			int score = int.Parse(scoreGT.text);

			//points
			score += 1;
			scoreGT.text = score.ToString();
			if(score > HighScore.score) {
				HighScore.score = score;
			}
		}
	}

}
