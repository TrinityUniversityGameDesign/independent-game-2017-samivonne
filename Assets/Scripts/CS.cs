using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CS : MonoBehaviour {
	int playerNum;
	int numPlayerReady;
	public GameObject p4Face; 
	public GameObject p3Face;
	public GameObject p2Face;
	public GameObject p1Face;
	bool p1isReady = false, p2isReady = false, p3isReady = false, p4isReady = false;

	// Use this for initialization
	void Start () {
		playerNum = PlayerPrefs.GetInt ("numPlayers");
		if (playerNum < 4) {
			//GameObject.Find ("P4Face").SetActive (false);
			p4Face.SetActive (false);
		}
		if (playerNum < 3) {
			//GameObject.Find ("P3Face").SetActive (false);
			p3Face.SetActive (false);
		}	
		if (playerNum < 2) {
			//GameObject.Find ("P2Face").SetActive (false);
			p2Face.SetActive (false);
		}
		numPlayerReady = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("P1Jump") > 0 && !p1isReady) {
			PlayerPrefs.SetInt ("P1Team", GameObject.Find("P1Face").GetComponent<PlayerSelect>().getPos()+1);
			p1isReady = true;
			numPlayerReady++;

		}
		if (Input.GetAxis ("P2Jump") > 0 && !p2isReady) {
			PlayerPrefs.SetInt ("P2Team", GameObject.Find("P2Face").GetComponent<PlayerSelect>().getPos()+1);
			p2isReady = true;
			numPlayerReady++;
		
		}
		if (Input.GetAxis ("P3Jump") > 0 && !p3isReady) {
			PlayerPrefs.SetInt ("P3Team", GameObject.Find("P3Face").GetComponent<PlayerSelect>().getPos()+1);
			p3isReady = true;
			numPlayerReady++;
		
		}
		if (Input.GetAxis ("P4Jump") > 0 && !p4isReady) {
			PlayerPrefs.SetInt ("P4Team", GameObject.Find("P4Face").GetComponent<PlayerSelect>().getPos()+1);
			p4isReady = true;
			numPlayerReady++;
	
		}
		if (numPlayerReady == playerNum) {
			SceneManager.LoadScene ("GenderSelection");
		}


	}
}
