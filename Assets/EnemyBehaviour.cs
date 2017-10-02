using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour {

	Rigidbody2D rb2D;

	private int groundmask;
	private bool grounded, onEdge;
	Transform EdgeCheck, GroundCheck;

	[SerializeField]
	float speed;

	// Use this for initialization
	void Awake () {
		groundmask = 1 << LayerMask.NameToLayer ("Ground");
		rb2D = GetComponent<Rigidbody2D> ();

		EdgeCheck = transform.Find ("EdgeCheck");
		GroundCheck = transform.Find ("GroundCheck");


	}

	// Update is called once per frame
	void Update () {
		grounded = Physics2D.OverlapCircle (GroundCheck.position,
			GroundCheck.GetComponent<CircleCollider2D> ().radius, 
			groundmask);

		onEdge = Physics2D.OverlapCircle (EdgeCheck.position,
			EdgeCheck.GetComponent<CircleCollider2D> ().radius, 
			groundmask);


		if (grounded && !onEdge)
			transform.localScale = new Vector3 (transform.localScale.x * -1, 
				transform.localScale.y, 
				transform.localScale.z);



		
	}

	void FixedUpdate(){

	}
}
