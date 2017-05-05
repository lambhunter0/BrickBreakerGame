using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int numberOfHits;
	private Sprite currentSprite;

	//method used to change the sprite being used for the object
	void changeSprite (){
		switch (numberOfHits) {
			case 0:
				currentSprite = Resources.Load("brick1",typeof(Sprite)) as Sprite;
				break;
			case 1:
				currentSprite = Resources.Load("brick2",typeof(Sprite)) as Sprite;
				break;
			case 2:
				currentSprite = Resources.Load("brick3",typeof(Sprite)) as Sprite;
				break;
			case 3:
				currentSprite = Resources.Load("brick4",typeof(Sprite)) as Sprite;
				break;
			default:
				break;
		}
	}

	// Use this for initialization
	void Start () {
		changeSprite ();
		GetComponent<SpriteRenderer>().sprite = currentSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
