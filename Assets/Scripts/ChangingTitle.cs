using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingTitle : MonoBehaviour {
	float counter = 2f;
	Text title;
	public float speed;
	// Use this for initialization
	void Start () {
		title = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		counter -= Time.deltaTime*speed;
//		if (counter <= 5) {
	//		title.color = Color.cyan;
		//} else if(counter >= 5) {
			title.color = Color.Lerp(Color.cyan, Color.blue, counter);
		//}
		if (counter < -2f) {
			counter = 2f;
		} 
	}
}
