using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleOrFemale : MonoBehaviour {

	private Sprite[] sp;
	private int pos = 0;
	public string axisHoriz;
	bool moving = false;


	// Use this for initialization
	void Start () {
		sp = new Sprite[2] {null,null};

		if(GetComponent<SpriteRenderer>().sprite.name.Contains("Pink")) {
			sp [0] = GetComponent<SpriteRenderer> ().sprite;
			sp [1] = Resources.Load<Sprite> ("Sprites/Players/PPinkfem");
		} else if(GetComponent<SpriteRenderer>().sprite.name.Contains("Green")) {
			sp [0] = GetComponent<SpriteRenderer> ().sprite;
			sp [1] = Resources.Load<Sprite> ("Sprites/Players/PGreenfem");
		} else if(GetComponent<SpriteRenderer>().sprite.name.Contains("Orange")) {
			sp [0] = GetComponent<SpriteRenderer> ().sprite;
			sp [1] = Resources.Load<Sprite> ("Sprites/Players/POrangefem");
		} else if(GetComponent<SpriteRenderer>().sprite.name.Contains("Blue")) {
			sp [0] = GetComponent<SpriteRenderer> ().sprite;
			sp [1] = Resources.Load<Sprite> ("Sprites/Players/PBluefem");
		}

	}

	public int getPos() {
		return pos;
	}

	// Update is called once per frame
	void Update () {
		float curPos = Input.GetAxis(axisHoriz);
		Debug.Log (axisHoriz + curPos);

		if (curPos >= .9) {

			if (moving == false) {
				moving = true;
				pos = (pos+1)%2;
			}
		} 
		if (curPos <= -.9) {
			if (moving == false) {
				moving = true;
				pos = (pos - 1) % 2;;
			}
		}
		if (curPos == 0) {

			//Debug.Log ("Moving " + moving);
			moving = false;
		}
		if (pos < 0) {
			pos = 1;
		}
		if (pos > 1) {
			pos = 0;
		}

		// 0 = female 
		// 1 = male

		GetComponent<SpriteRenderer>().sprite = sp[pos];




	}

}
