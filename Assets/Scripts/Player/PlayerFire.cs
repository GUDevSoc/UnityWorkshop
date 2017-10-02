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
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		mouseClick = Input.GetMouseButtonDown (0);

		if (mouseClick && shootTimer <= 0 && shootSpeed >= 0) {
			shootTimer = 1 / shootSpeed;
			Instantiate (projectile, transform.position, transform.rotation, transform);
		}

		if (shootTimer > 0) {
			shootTimer -= Time.deltaTime;
		}
	}
}
