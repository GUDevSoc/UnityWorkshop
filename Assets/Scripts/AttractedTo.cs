﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractedTo : MonoBehaviour {

	public float strengthOfAttraction = 10;
	public float radius = 1.5f;
	public float maxSpeed = 10;

	private Rigidbody2D rb2d;
	private Transform attractedTo;

	// Use this for initialization
	void Start () {
		attractedTo = GameObject.Find ("Player").GetComponent<Transform>();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//get the offset between the objects
		Vector2 offset = (Vector2) (attractedTo.position - transform.position);

		if (offset.magnitude <= radius) {
			Vector2 vel = rb2d.velocity;
			vel += offset;
			rb2d.velocity = vel;
		}

		if (Mathf.Abs (rb2d.velocity.magnitude) > maxSpeed) {
			rb2d.velocity = rb2d.velocity.normalized * maxSpeed;
		}
	}
}
