using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {

	public Transform[] locs;
	private int pos = 0;
	public string axisHoriz;
	bool moving = false;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		float curPos = Input.GetAxis(axisHoriz);
		Debug.Log (axisHoriz + curPos);

		if (curPos >= .9) {
			
			if (moving == false) {
				moving = true;
				pos += 1;
			}
		} 
		if (curPos <= -.9) {
			if (moving == false) {
				moving = true;
				pos -= 1;
			}
		}
		if (curPos == 0) {

			//Debug.Log ("Moving " + moving);
			moving = false;
		}
		if (pos < 0) {
			pos = 0;
		}
		if (pos > 3) {
			pos = 0;
		}

		transform.position = locs [pos].position; 

	
	}

}
