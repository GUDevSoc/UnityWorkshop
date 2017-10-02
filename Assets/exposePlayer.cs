using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exposePlayer : MonoBehaviour {

	[HideInInspector]
	public Transform player;
	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D c) {
		if (c.CompareTag ("Player"))
			player = c.transform;
		
	}

	void OnTriggerExit2D(Collider2D c){
		if (c.CompareTag ("Player"))
			player = null;

	}
}
