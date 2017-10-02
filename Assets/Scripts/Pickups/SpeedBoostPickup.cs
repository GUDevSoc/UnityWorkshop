using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPickup : Pickup {
	protected override void CollectableBehaviour(GameObject player){
		player.AddComponent<SpeedBoostPowerup> ();
	}
}
