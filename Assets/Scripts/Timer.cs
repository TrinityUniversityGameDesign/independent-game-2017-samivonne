using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public float timer = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		GetComponent<Text> ().text = timer.ToString();
		if (timer <= 0) {
			SceneManager.LoadScene ("Congrats");
		}
	}
}
