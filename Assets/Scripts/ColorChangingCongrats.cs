using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangingCongrats : MonoBehaviour {
	float counter = 10f;
	Text title;
	//public Color color1;
	//public Color color2;
	public float speed;
	Color c = new Color (1f,1f,.3f,.8f);
	Color c2 = new Color (1f, .4f, .7f, .8f);
	// Use this for initialization
	void Start () {
		title = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		counter -= Time.deltaTime*speed;
	

		title.color = Color.Lerp(c, c2, counter);	
		if (counter < -10f) {
			counter = 10f;
		} 
	}
}
