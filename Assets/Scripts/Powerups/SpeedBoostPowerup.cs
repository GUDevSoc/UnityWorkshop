using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPowerup : Powerup {

	public float moveBoost = 3f;
	public float fireBoost = 3f;

	protected override void doPowerUp(){
		GetComponent<PlayerMove> ().maxSpeed += moveBoost;
		GetComponentInChildren<PlayerFire> ().shootSpeed += fireBoost;
	}

	protected override void undoPowerUp(){
		GetComponent<PlayerMove> ().maxSpeed -= moveBoost;
		GetComponentInChildren<PlayerFire> ().shootSpeed -= fireBoost;
	}
}
