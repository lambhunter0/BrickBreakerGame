using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	public GameObject rightWall;
	public GameObject leftWall;
	private int health;

	void Start(){
		health = 3;
	}

	void Update () {
		moveInput ();
		checkBoundaries ();
		//Die ();
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
		if (transform.position.x > rightWall.transform.position.x){
			Vector3 pos = new Vector3 (leftWall.transform.position.x,transform.position.y,transform.position.z);
			transform.position = pos;
		}
		if (transform.position.x < leftWall.transform.position.x){
			Vector3 pos = new Vector3 (rightWall.transform.position.x,transform.position.y,transform.position.z);
			transform.position = pos;
		}
	}

	public void removeHealth(){
		health--;
	}

	//void Die(){
	//	if (health < 1) {
	//		//GameObject.Destroy (this);
	//		//die code
	//	}
	//}
}
