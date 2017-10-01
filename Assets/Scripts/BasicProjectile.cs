using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectile : MonoBehaviour {

	public GameObject explosion;
	private Rigidbody2D rb2d;

	void Awake(){
		rb2d = GetComponent<Rigidbody2D> ();
		GetComponent<SpriteRenderer> ().color = GetComponentInParent<SpriteRenderer> ().color;
	}

	// Use this for initialization
	void Start () {
		Debug.Log (transform.parent.GetComponent<PlayerFire> ().shootForce);
		rb2d.AddRelativeForce (new Vector2 (transform.parent.GetComponent<PlayerFire> ().shootForce, 0));
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = rb2d.velocity;

		if(v.magnitude > 0.01){
			float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg; 
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag != "Player") {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}