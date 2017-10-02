using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.transform.name == "Player"){
			CollectableBehaviour (collision.gameObject);
			Destroy (gameObject);
		}
			
	}

	protected abstract void CollectableBehaviour (GameObject player);
}
