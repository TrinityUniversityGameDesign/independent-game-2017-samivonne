using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float walkSpeed = 10f;
	public float jumpPower = 300f;
	private Rigidbody2D theRigidBody;

	public LayerMask groundLayer;

	public string axisHoriz;
	public string axisJump;



	private Vector2 resetPosition;
	private Transform leftCheck;
	private Transform rightCheck;

	bool facingRight = true;


	// Use this for initialization
	void Start () {
		theRigidBody = GetComponent<Rigidbody2D> ();
		leftCheck = transform.Find ("LeftCheck");
		rightCheck = transform.Find ("RightCheck");
		resetPosition = transform.position;

	

	}

	// Update is called once per frame
	void Update () {

		float inX = Input.GetAxis (axisHoriz);
		theRigidBody.velocity = new Vector3(inX*walkSpeed,theRigidBody.velocity.y, 0f);
		if (inX > 0 && !facingRight) {
			Flip ();
		} else if (inX < 0 && facingRight) {
			Flip ();
		}
		//transform.rotation = Quaternion.LookRotation (theRigidBody.velocity);

		bool jumping = Input.GetButtonDown (axisJump);
		bool grounded = Physics2D.OverlapCircle (leftCheck.position, .1f, groundLayer) || Physics2D.OverlapCircle (rightCheck.position, .1f, groundLayer) ;
		//CHECK TO SEE IF PLAYER IS GROUNDED
		Debug.Log ("Grounded? " + grounded);

		if (grounded && jumping) {
			theRigidBody.AddForce (new Vector2(0f, jumpPower));
		}



	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
		
}