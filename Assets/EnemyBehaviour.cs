using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour {

	Rigidbody2D rb2D;

	private int groundmask;
	private bool grounded, onEdge;
	Transform EdgeCheck, GroundCheck;
	Health health;

	[SerializeField]
	float speed = 20;

	// Use this for initialization
	void Awake () {
		groundmask = 1 << LayerMask.NameToLayer ("Ground");
		rb2D = GetComponent<Rigidbody2D> ();

		EdgeCheck = transform.Find ("EdgeCheck");
		GroundCheck = transform.Find ("GroundCheck");
		health = GetComponent<Health> ();


	}

	// Update is called once per frame
	void Update () {

		if (health.isDead)
			Destroy (gameObject);
		//check if on ground
		grounded = Physics2D.OverlapCircle (GroundCheck.position,
			GroundCheck.GetComponent<CircleCollider2D> ().radius, 
			groundmask);

		//check if front is over edge of stage
		onEdge = Physics2D.OverlapCircle (EdgeCheck.position,
			EdgeCheck.GetComponent<CircleCollider2D> ().radius, 
			groundmask);


		if (grounded && !onEdge) { //if off edge, flip
			transform.localScale = new Vector3 (transform.localScale.x * -1, 
				transform.localScale.y, 
				transform.localScale.z);
			
			speed *= -1;

		}



		
	}

	void FixedUpdate(){
		rb2D.velocity = Vector2.right * speed;
	}
}
