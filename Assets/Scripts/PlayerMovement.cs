using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float walkSpeed = 10f;
	public float jumpPower = 300f;
	private Rigidbody2D theRigidBody;

	public LayerMask groundLayer;


	private Vector2 resetPosition;
	private Transform leftCheck;
	private
	Transform rightCheck;

	// Use this for initialization
	void Start () {
		theRigidBody = GetComponent<Rigidbody2D> ();
		leftCheck = transform.Find ("LeftCheck");
		rightCheck = transform.Find ("RightCheck");
		resetPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {

		float inX = Input.GetAxis ("Horizontal");
		theRigidBody.velocity = new Vector2(inX*walkSpeed,theRigidBody.velocity.y);

		bool jumping = Input.GetButtonDown ("Jump");
		bool grounded = Physics2D.OverlapCircle (leftCheck.position, 0.1f, groundLayer) || Physics2D.OverlapCircle (rightCheck.position, 0.1f, groundLayer) ;


		if (grounded && jumping) {
			theRigidBody.AddForce (new Vector2(0f, jumpPower));
		}
	}
		
}