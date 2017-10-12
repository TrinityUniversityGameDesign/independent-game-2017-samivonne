using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour {

	public delegate void OnBucket(int whichPlayer, int waterNumber);
	public event OnBucket onBucket;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerStay2D(Collider2D col) {
		Debug.Log("!!!!!!!");
		if (col.gameObject.tag == "Bucket") {
			if (onBucket != null) {
				if (GetComponentInChildren<Shooting> ().howMuchWater > 0) {
					
					GetComponentInChildren<Shooting> ().howMuchWater--;
					onBucket (GetComponent<PlayerMovement> ().PlayerNumber, GetComponentInChildren<Shooting> ().howMuchWater);	

				}
			}
		}
	}
}
