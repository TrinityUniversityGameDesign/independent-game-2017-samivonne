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

	public void OnTriggerEnter2D(Collider2D col) {
		Debug.Log("!!!!!!!");
		if (col.gameObject.tag == "Bucket") {
			if(onBucket != null) {
			//access the canvas's bucketlevels
				//Debug.Log(" *******" +GetComponent<PlayerMovement>());
				//Debug.Log(" AAAAAAA" + GetComponent<Shooting>());
			onBucket(GetComponent<PlayerMovement>().PlayerNumber, GetComponentInChildren<Shooting>().HowMuchWater);			
			}
		}
	}
}
