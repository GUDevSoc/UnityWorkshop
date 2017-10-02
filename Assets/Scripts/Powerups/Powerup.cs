using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour {

	// -1 for INFINITE TIME
	public float time = 60;
	private Rigidbody2D rb2d;

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
		doPowerUp ();
	}

	void Update(){
		time -= Time.deltaTime;
		if (time <= 0) {
			undoPowerUp ();
			Destroy (this);
		}
	}

	protected abstract void doPowerUp ();

	protected abstract void undoPowerUp ();
}
