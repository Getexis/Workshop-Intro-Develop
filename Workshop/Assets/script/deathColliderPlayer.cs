﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathColliderPlayer : MonoBehaviour {
	public gameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		//Destroy(this.gameObject);
		if(other.gameObject.tag == "dead")
			gameManager.Death();
	}
}
