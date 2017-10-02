using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Transform target;

	public void Start(){
		target = GameObject.Find ("Player").GetComponent<Transform>();
	}

	public void Update(){
		Vector3 cameraPos = new Vector3 (target.position.x, target.position.y, transform.position.z);
		transform.position = cameraPos;
	}

}