using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	
	void Update () {
		moveInput ();
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
}
