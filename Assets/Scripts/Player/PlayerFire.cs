using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

	public GameObject projectile;
	public float shootForce = 500f;
	public float shootSpeed = 1f;

	private bool mouseClick = false;
	private float shootTimer = 0;

	// Use this for initialization
	void Awake(){
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseClick = Input.GetButton ("Fire1");

		if (mouseClick && shootTimer <= 0 && shootSpeed >= 0) {
			shootTimer = 1 / shootSpeed;
			GameObject proj = (GameObject) Instantiate (projectile, transform.position, transform.rotation, transform);
			proj.GetComponent<BasicProjectile> ().shootForce = shootForce;
		}

		if (shootTimer > 0) {
			shootTimer -= Time.deltaTime;
		}
	}
}
