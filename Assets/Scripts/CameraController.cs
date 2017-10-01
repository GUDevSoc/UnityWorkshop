using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;

	public void Update(){
		Vector3 cameraPos = new Vector3 (target.position.x, target.position.y, transform.position.z);
		transform.position = cameraPos;
	}

}