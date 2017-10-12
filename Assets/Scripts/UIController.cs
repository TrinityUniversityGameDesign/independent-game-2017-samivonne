using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
	public GameObject[] buckets;
	public GameObject[] guns;
	// Use this for initialization
	void Start () {
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Players");
		foreach(GameObject player in players) {
			player.GetComponent<BucketController>().onBucket += LowerLevels;
			//player.GetComponent<TubController> ().onTub += HeightenLevels;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LowerLevels(int player, int level) {
		//Debug.Log ("!!OOOO!!");
		if (level > 0) {
			int team = PlayerPrefs.GetInt ("P" + player + "Team");
			//Debug.Log ("BUCKET" + buckets[team].GetComponent<RectTransform>().sizeDelta);
			buckets[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, level/5);
			guns[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, -level/5);

		}
		if (level < 0) {
			level = 0;
		}
		//Debug.Log (":)");
	}
	public void HeightenLevels(int player, int level) {
		if (level < 40) {
			int team = PlayerPrefs.GetInt ("P" + player + "Team");
			//Debug.Log ("BUCKET" + buckets[team].GetComponent<RectTransform>().sizeDelta);
			//buckets[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, level/5);
			guns[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, level/5);
		}
		if (level > 40) {
			level = 40;
		}
	}
}
