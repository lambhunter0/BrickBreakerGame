using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	public GameObject playerPrefab;
	public GameObject ballPrefab;
	public GameObject playerSpawn;
	public GameObject ballSpawn;

	void Start () {
		Instantiate (playerPrefab, playerSpawn.transform);
		Instantiate (ballPrefab,ballSpawn.transform);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
