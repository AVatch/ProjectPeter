using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	void Awake()
	{
		if ( instance == null )
		{
			instance = this;
		}else if(instance != this)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}



	private int score = 0;



	// Use this for initialization
	void Start () {
		Debug.Log("GameManagerStarted");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setScore(int delta) {
		score += delta;
	}
	public int getScore() {
		return score;
	}
}
