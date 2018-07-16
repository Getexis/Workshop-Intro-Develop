using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameManager : MonoBehaviour {
	public  int life;
	public GameObject player;
	public GameObject enemy;
	public Vector3 positionStarterPlayer;
	public Vector3 positionStarterEnemy;
	public GameObject mainCamera;
	public Text countText;
	// Use this for initialization
	void Start () {
		countText.text = life.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Death(){
		life --;
		countText.text = life.ToString();

		if(player)
			player.transform.position = positionStarterPlayer;
		if(enemy)
			enemy.transform.position = positionStarterEnemy;
		if(mainCamera)
			mainCamera.transform.position = new Vector3(0,0,mainCamera.transform.position.z);
	}
}
