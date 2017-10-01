using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour {
	private AnimationClip anim;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		Animator animator = GetComponent<Animator> ();
		//animator.speed = 12;
		anim = animator.runtimeAnimatorController.animationClips[0];
		audio = GetComponent<AudioSource>();
		StartCoroutine (doAnimation());
		StartCoroutine (doDestroy ());
	}

	private IEnumerator doAnimation(){
		yield return new WaitForSeconds(anim.length);
		Destroy (GetComponent<SpriteRenderer>());
	}

	private IEnumerator doDestroy(){
		yield return new WaitForSeconds (anim.length);
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
}