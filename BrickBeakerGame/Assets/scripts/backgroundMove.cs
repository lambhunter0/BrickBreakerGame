using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour {

	//this script makes the background scroll to give it a cool efffect. we can deactivate this whenever
	//im just implementing something from an assignment cause I think it looks cool
	public float speed = 0.5f;

	void Update(){
		Vector2 backgroundMvt = new Vector2 (0, (Time.time * speed)%1);
		GetComponent<Renderer> ().material.mainTextureOffset = backgroundMvt;
	}
}
