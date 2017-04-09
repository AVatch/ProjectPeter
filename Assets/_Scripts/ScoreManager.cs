using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		renderScore ();
	}

	void renderScore()
	{
		int score = GameManager.instance.getScore ();

		Text scoreText = gameObject.GetComponent<Text> ();
		scoreText.text = score.ToString ();
	}
		
}
