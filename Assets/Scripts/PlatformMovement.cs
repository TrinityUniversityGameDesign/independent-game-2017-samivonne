using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
	
	public float rightLimit = 2.5f;
	public float leftLimit = -2.5f;
	public float speed = 2.0f;
	private float direction = 1f;
	//private Vector3 movement;

	private Rigidbody2D platform;

	// Use this for initialization
	void Start () {
		platform = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (transform.position.x > rightLimit) {
			direction = -2;
		}
		else if (transform.position.x < leftLimit) {
			direction = 2;
		}
		//movement = Vector3.right * direction * speed * Time.deltaTime;
		platform.velocity = new Vector3(direction, 0f, 0f);
		//transform.Translate(movement); 
	}
}
