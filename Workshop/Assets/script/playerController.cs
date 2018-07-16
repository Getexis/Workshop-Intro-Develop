using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	Rigidbody2D body;
	public float maxSpeed = 10f;
	public bool ground;
	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float move = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(move * maxSpeed, body.velocity.y);

		if(Input.GetButtonDown("Jump") && ground ){
			body.AddForce(Vector2.up * maxSpeed, ForceMode2D.Impulse);
			ground = false;
		}
			
	}
	void OnCollisionEnter2D(Collision2D  other){
		if(other.gameObject.tag == "ground")
			ground = true;
	}
}
