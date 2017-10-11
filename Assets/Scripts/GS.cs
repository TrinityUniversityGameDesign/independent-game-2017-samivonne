using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GS : MonoBehaviour {
	int p1team;
	int p2team;
	int p3team;
	int p4team;
	int playerNum;
	// pink = 0, orange = 1, green = 2, blue =3
	public Sprite[] sp;

	bool p1isReady = false, p2isReady = false, p3isReady = false, p4isReady = false;
	int numPlayerReady;

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;
	// Use this for initialization
	void Start () {


		p1team = (PlayerPrefs.GetInt ("P1Team") - 1) % 4;
		p2team = (PlayerPrefs.GetInt ("P2Team") - 1) % 4;
		p3team = (PlayerPrefs.GetInt ("P3Team") - 1) % 4;
		p4team = (PlayerPrefs.GetInt ("P4Team") - 1) % 4;


		playerNum = PlayerPrefs.GetInt ("numPlayers");
		if (playerNum == 4) {
			player1.GetComponent<SpriteRenderer> ().sprite = sp [p1team];
			player2.GetComponent<SpriteRenderer> ().sprite = sp [p2team];
			player3.GetComponent<SpriteRenderer> ().sprite = sp [p3team];
			player4.GetComponent<SpriteRenderer> ().sprite = sp [p4team];

			player1.SetActive (true);
			player2.SetActive (true);
			player3.SetActive (true);
			player4.SetActive (true);

		} else if (playerNum == 3) {
			player1.GetComponent<SpriteRenderer> ().sprite = sp [p1team];
			player2.GetComponent<SpriteRenderer> ().sprite = sp [p2team];
			player3.GetComponent<SpriteRenderer> ().sprite = sp [p3team];

			player1.SetActive (true);
			player2.SetActive (true);
			player3.SetActive (true);
			player4.SetActive (false);
			GameObject.Find ("P4RightArrow").SetActive (false);
			GameObject.Find ("P4LeftArrow").SetActive (false);

		} else if (playerNum == 2) {
			player1.GetComponent<SpriteRenderer> ().sprite = sp [p1team];
			player2.GetComponent<SpriteRenderer> ().sprite = sp [p2team];

			player1.SetActive (true);
			player2.SetActive (true);
			player3.SetActive (false);
			player4.SetActive (false);
			GameObject.Find ("P3RightArrow").SetActive (false);
			GameObject.Find ("P3LeftArrow").SetActive (false);
			GameObject.Find ("P4RightArrow").SetActive (false);
			GameObject.Find ("P4LeftArrow").SetActive (false);
		} else {
			player1.GetComponent<SpriteRenderer>().sprite = sp [p1team];

			player1.SetActive (true);
			player2.SetActive (false);
			player3.SetActive (false);
			player4.SetActive (false);
			GameObject.Find ("P2RightArrow").SetActive (false);
			GameObject.Find ("P2LeftArrow").SetActive (false);
			GameObject.Find ("P3RightArrow").SetActive (false);
			GameObject.Find ("P3LeftArrow").SetActive (false);
			GameObject.Find ("P4RightArrow").SetActive (false);
			GameObject.Find ("P4LeftArrow").SetActive (false);

		}


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("P1Jump") > 0 && !p1isReady) {
			PlayerPrefs.SetInt ("P1Choice", GameObject.Find("PlayerPmale").GetComponent<MaleOrFemale>().getPos());
			p1isReady = true;
			numPlayerReady++;

		}
		if (Input.GetAxis ("P2Jump") > 0 && !p2isReady) {
			PlayerPrefs.SetInt ("P2Choice", GameObject.Find("PlayerOmale").GetComponent<MaleOrFemale>().getPos());
			p2isReady = true;
			numPlayerReady++;

		}
		if (Input.GetAxis ("P3Jump") > 0 && !p3isReady) {
			PlayerPrefs.SetInt ("P3Choice", GameObject.Find("PlayerGmale").GetComponent<MaleOrFemale>().getPos());
			p3isReady = true;
			numPlayerReady++;

		}
		if (Input.GetAxis ("P4Jump") > 0 && !p4isReady) {
			PlayerPrefs.SetInt ("P4Choice", GameObject.Find("PlayerBmale").GetComponent<MaleOrFemale>().getPos());
			p4isReady = true;
			numPlayerReady++;

		}
		if (numPlayerReady == playerNum) {
			SceneManager.LoadScene ("MainScene");
		}
	}
}
