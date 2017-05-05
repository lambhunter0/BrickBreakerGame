using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public float speed;
	public Rigidbody2D ballBody;

	void Start () {
		ballBody.AddForce (new Vector2(speed,speed));
	}

	void Update () {

	}
}
