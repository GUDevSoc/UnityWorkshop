using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	[SerializeField]
	float maxhealth = 100;
	float health;

	[HideInInspector]
	public bool isDead = false;
	public Team team;

	// Use this for initialization
	void Start () {
		health = maxhealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		//death check

		if (health <= 0)
			isDead = true;
	}

	void OnCollisionEnter2D(Collision2D c){
		if (isDead)
			return;

		Damage dmg = c.transform.GetComponent<Damage> (); 

		if (dmg && team != dmg.team) {
			health -= dmg.damage;
			Debug.Log (health);
		}
	}
}
