using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public ParticleSystem waterspout;
	public string axisFire;
	// Use this for initialization
	void Start () {
		//waterspout = GetComponentInChildren<ParticleSystem>();
		Debug.Log (waterspout);
	}
	
	// Update is called once per frame
	void Update () {
		float shooting = Input.GetAxis(axisFire);
		//Debug.Log (Input.GetAxis(axisFire));
		if (shooting >= .9f) {
			Debug.Log ("Shooting? " + shooting);
			waterspout.Play ();
		}

	}
}
