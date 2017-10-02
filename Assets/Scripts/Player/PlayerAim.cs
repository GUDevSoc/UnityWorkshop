using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

	float mouseAngle;

	// Use this for initialization
	void Start () {
		gameObject.transform.localPosition = new Vector3 (0, 0, 0);
	}

	void Update(){
		mouseAngle = getMouseAngle ();
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		if (mouseAngle > 270) {
			mouseAngle = 0;
		} else if (mouseAngle > 180) {
			mouseAngle = 180;
		}

		gameObject.transform.eulerAngles = new Vector3 (0, 0, mouseAngle);
	}

	float getMouseAngle(){
		Vector3 mousePos;
		float angle;

		mousePos = Input.mousePosition;
		mousePos.z = (gameObject.transform.position.z - Camera.main.transform.position.z);
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);
		mousePos = mousePos - gameObject.transform.position;
		angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		if (angle < 0.0f) {
			angle += 360.0f;
		}

		return angle;
	}
}
