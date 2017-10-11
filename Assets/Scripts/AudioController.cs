using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
	public AudioClip shootsound;
	// Use this for initialization
	void Start () {
		GameObject[] guns = GameObject.FindGameObjectsWithTag ("Gun");
		foreach(GameObject gun in guns) {
			gun.GetComponent<Shooting> ().onShoot += PlayShootSound;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayShootSound(int whoShot, bool firstShot) {
		if (firstShot == true) {
			GetComponent<AudioSource> ().PlayOneShot (shootsound, 1f);
		}
	}
}
