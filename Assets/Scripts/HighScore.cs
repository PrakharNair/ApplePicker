using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
	static public int score = 10;

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		if(PlayerPrefs.HasKey("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt("ApplePickerHighScore");
		}
		PlayerPrefs.SetInt("ApplePickerHighScore", score);
	}

	// Update is called once per frame
	void Update () {

		TextMesh scoreGT = this.GetComponent<TextMesh>();

		scoreGT.text = "High Score: " + score; 
		
		if(score > PlayerPrefs.GetInt("ApplePickerHighScore")) {
			PlayerPrefs.SetInt("ApplePickerHighScore", score);
		}
	}
}
