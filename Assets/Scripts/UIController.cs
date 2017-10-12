using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	public GameObject[] buckets;
	public GameObject[] guns;
	// Use this for initialization
	void Start () {
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Players");
		foreach(GameObject player in players) {
			player.GetComponent<BucketController>().onBucket += LowerLevels;
			player.GetComponent<TubController> ().onTub += HeightenLevels;
			player.GetComponentInChildren<Shooting> ().onShoot += LoseWater;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LowerLevels(int player, int level) {
		
		if (level > 0) {
			int team = PlayerPrefs.GetInt ("P" + player + "Team");
			Debug.Log (buckets[team].GetComponent<RectTransform>().rect.height);
			//Debug.Log ("BUCKET" + buckets[team].GetComponent<RectTransform>().sizeDelta);
			buckets[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, buckets[team].GetComponent<RectTransform>().rect.height + level/100f);
			guns[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,guns[team].GetComponent<RectTransform>().rect.height - level/100f);

			if (buckets[team].GetComponent<RectTransform>().rect.height >= 40f) {
				SceneManager.LoadScene ("Congrats");
			}
		}
			
	

		//Debug.Log (":)");
	}
	public void HeightenLevels(int player, int level) {
	//	if (level < 40) {
			int team = PlayerPrefs.GetInt ("P" + player + "Team");
			//Debug.Log ("BUCKET" + buckets[team].GetComponent<RectTransform>().sizeDelta);
			//buckets[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, level/5);
			guns[team].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, guns[team].GetComponent<RectTransform>().rect.height + level/100f);
	//	}
	

	}
	public void LoseWater(int player, bool ff) {
		
			int team = PlayerPrefs.GetInt ("P" + player + "Team");
			guns [team].GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, guns [team].GetComponent<RectTransform> ().rect.height - .2f);

	}

}
