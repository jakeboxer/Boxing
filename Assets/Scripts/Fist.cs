using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {
	public enum FistSide { Left, Right };

	public FistSide fistSide;

	private Animator animator;
	private PlayerController controller;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		controller = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GetControlState() == PlayerController.ControlState.Punch) {
			animator.SetInteger("AnimState", 2);
		} else {
			animator.SetInteger("AnimState", 0);
		}
	}

	PlayerController.ControlState GetControlState () {
		if (fistSide == FistSide.Left) {
			return controller.leftControlState;
		} else {
			return controller.rightControlState;
		}
	}
}
