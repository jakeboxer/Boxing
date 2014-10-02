using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {
	public enum FistSide { Left, Right };

	public FistSide fistSide;

	private Animator animator;
	private PlayerController controller;
	private Vector2 idlePosition;
	private Vector2 punchingPosition;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		controller = GetComponent<PlayerController>();

		idlePosition = transform.position;

		float punchingX = idlePosition.x + (fistSide == FistSide.Left ? 1.5f : -1.5f);
		float punchingY = idlePosition.y + 3f;
		punchingPosition = new Vector2(punchingX, punchingY);
	}
	
	// Update is called once per frame
	void Update () {
		if (GetControlState() == PlayerController.ControlState.Punch) {
			animator.SetInteger("AnimState", 2);
			transform.position = punchingPosition;
		} else {
			animator.SetInteger("AnimState", 0);
			transform.position = idlePosition;
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
