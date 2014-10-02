using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {
	private Animator animator;
	private PlayerController controller;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		controller = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (controller.rightHandState == PlayerController.PUNCHING) {
			animator.SetInteger("AnimState", 1);
		} else {
			animator.SetInteger("AnimState", 0);
		}
	}
}
