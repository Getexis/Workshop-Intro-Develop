﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRotate : MonoBehaviour {
	public int forceRotate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") > 0 )
			transform.Rotate(Vector3.back * forceRotate * Time.deltaTime);
		if(Input.GetAxis("Horizontal") < 0)
			transform.Rotate(Vector3.forward * forceRotate * Time.deltaTime);
			
	}
}
