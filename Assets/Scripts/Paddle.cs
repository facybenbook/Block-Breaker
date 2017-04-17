﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3 (-7.5f, this.transform.position.y , -0.25f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
			print ("Dubug Update Call in Paddle script");
			
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, -7.5f, 7.5f);
			
		this.transform.position = paddlePos;
	
	}
}