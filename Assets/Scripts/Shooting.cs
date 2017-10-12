using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public ParticleSystem waterspout;
	public string axisFire;
	bool isShooting = false;

	public int howMuchWater;

	public delegate void OnShoot(int whoShot, bool firstFrame);
	public event OnShoot onShoot;

	// Use this for initialization
	void Start () {
		//!!!!!!!! -> want to set the howMuchWater int to be equal to the level 

	}
	
	// Update is called once per frame
	void Update () {
		float shooting = Input.GetAxis(axisFire);
		//Debug.Log (Input.GetAxis(axisFire));
		if(howMuchWater > 0) {
			if (shooting >= .9f) {
				if (onShoot != null) {
					int pNum = (int)System.Char.GetNumericValue (gameObject.name [gameObject.name.Length - 1]);
					bool first = false;
					if (!isShooting) {  //first time 
						first = true;
					}
					onShoot (pNum, first);
				}
				isShooting = true;
				waterspout.Play ();
				howMuchWater--;
			
			}
		} else {
			isShooting = false;
		}

	}
}
