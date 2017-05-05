using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	public Transform rightWall;
	public Transform leftWall;

	void Update () {
		moveInput ();
		checkBoundaries ();
	}

	void moveInput(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			//moveright
			//for now use translate, we might use physical movements later to allow for different kinds of powerups/powerdowns
			transform.Translate(new Vector2(1,0)*speed*Time.deltaTime,Space.World);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//moveleft
			transform.Translate(new Vector2(-1,0)*speed*Time.deltaTime,Space.World);
		}
	}

	void checkBoundaries(){
		if (transform.position.x > rightWall.position.x){
			Vector3 pos = new Vector3 (leftWall.position.x,transform.position.y,transform.position.z);
			transform.position = pos;
		}
		if (transform.position.x < leftWall.position.x){
			Vector3 pos = new Vector3 (rightWall.position.x,transform.position.y,transform.position.z);
			transform.position = pos;
		}
	}
}
