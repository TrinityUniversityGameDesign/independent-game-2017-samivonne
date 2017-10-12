using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubController : MonoBehaviour {

	public delegate void OnTub(int whichPlayer, int waterNumber);
	public event OnTub onTub;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Tub") {
			if(onTub != null) {
				//access the canvas's bucketlevels
				//Debug.Log(" *******" +GetComponent<PlayerMovement>());
				//Debug.Log(" AAAAAAA" + GetComponent<Shooting>());
				onTub(GetComponent<PlayerMovement>().PlayerNumber, GetComponentInChildren<Shooting>().howMuchWater);
				GetComponentInChildren<Shooting> ().howMuchWater++;
			}
		}
	}
}
