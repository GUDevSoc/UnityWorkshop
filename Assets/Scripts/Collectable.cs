using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.transform.name == "Player"){
			CollectableBehaviour (collision);
			Destroy (gameObject);
		}
			
	}

	void CollectableBehaviour(Collision2D collision){
		collision.gameObject.GetComponent<ScoreTracker> ().score++;
	}
}
