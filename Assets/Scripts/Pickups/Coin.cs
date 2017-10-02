using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Pickup {
	protected override void CollectableBehaviour(GameObject player){
		player.gameObject.GetComponent<ScoreTracker> ().score++;
	}
}
