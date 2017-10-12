using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MS : MonoBehaviour {
	string whichCharP1, whichCharP2, whichCharP3, whichCharP4;
	public GameObject player1, player2, player3, player4;
	int howMany;
	// Use this for initialization
	void Start () {
		whichCharP1 = PlayerPrefs.GetString ("P1Final");
		whichCharP2 = PlayerPrefs.GetString ("P2Final");
		whichCharP3 = PlayerPrefs.GetString ("P3Final");
		whichCharP4 = PlayerPrefs.GetString ("P4Final");
		howMany = PlayerPrefs.GetInt ("numPlayers");

		player1.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Sprites/Players/" + whichCharP1);
		player2.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Sprites/Players/" + whichCharP2);
		player3.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Sprites/Players/" + whichCharP3);
		player4.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Sprites/Players/" + whichCharP4);


		if (howMany < 4) {
			player4.SetActive (false);
		} 
		if (howMany < 3) {
			player3.SetActive (false);
		} 
		if (howMany < 2) { 
			player2.SetActive (false);
		}


	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
