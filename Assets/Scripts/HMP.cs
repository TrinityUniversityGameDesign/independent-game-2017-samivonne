using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HMP : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("P1Jump") > 0) {
			PlayerPrefs.SetInt ("numPlayers", GameObject.Find("Pointer").GetComponent<PlayerSelect>().getPos()+1);
			SceneManager.LoadScene ("CharacterSelect");
		}
	}
}
