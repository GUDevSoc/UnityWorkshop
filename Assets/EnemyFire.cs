using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

	public GameObject projectile;
	Transform barrel;
	public float shootForce = 500f;
	public float shootSpeed = 1f;

	private bool mouseClick = false;
	private float shootTimer = 0;

	// Use this for initialization
	void Awake () {
		foreach (Transform child in GetComponentsInChildren<Transform>()) {
			if (child.name == "Barrel")
				barrel = child;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponentInChildren<exposePlayer>().player && shootTimer <= 0 && shootSpeed >= 0) {
			shootTimer = 1 / shootSpeed;
			GameObject proj = (GameObject) Instantiate (projectile, barrel.position, barrel.rotation, barrel);
			proj.GetComponent<Damage> ().team = Team.Enemy;
			proj.GetComponent<BasicProjectile> ().shootForce = shootForce;
		}

		if (shootTimer > 0) {
			shootTimer -= Time.deltaTime;
		}
	}
}
