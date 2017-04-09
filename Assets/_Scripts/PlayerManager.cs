using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("tick", 0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void tick(){
		GameManager.instance.setScore (10);
	}

}
