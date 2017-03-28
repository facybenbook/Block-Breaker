﻿using UnityEngine;
using System.Collections;

public class LoseCollidor : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider){
		print ("Trigger");
		levelManager.LoadLevel("Win");
		
	}
	
	void OnCollisionEnter2D (Collision2D collision){
		print ("Collision");
	}
}