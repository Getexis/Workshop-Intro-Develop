using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarget : MonoBehaviour {
	public Transform targetGameObject;
	public bool verticalFixed;
	public bool horizontalFixed;
	public float speedCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(horizontalFixed){
			if(targetGameObject.position.y > 5)
						transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetGameObject.position.y, transform.position.z), speedCamera * Time.deltaTime);
			else
				transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0, transform.position.z), speedCamera * Time.deltaTime);
		}
		if(verticalFixed){
				transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetGameObject.position.x,transform.position.y, transform.position.z), speedCamera * Time.deltaTime);
		}
	}
}