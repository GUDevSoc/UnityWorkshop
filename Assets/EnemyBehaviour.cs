using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour {

	Rigidbody2D rb2D;
	Transform R_Edge, L_Edge;

	private int groundmask;

	// Use this for initialization
	void Awake () {
		groundmask = 1 << LayerMask.NameToLayer ("Ground");
		rb2D = GetComponent<Rigidbody2D> ();

		R_Edge = transform.Find ("EdgeCheck_R");
		L_Edge = transform.Find ("EdgeCheck_L");


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){

	}
}
