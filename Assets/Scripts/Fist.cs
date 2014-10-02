using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {
	public enum FistSide { Left, Right };

	public FistSide fistSide;

	private Animator animator;
	private PlayerController controller;

	private Vector2 idlePosition;
	private Vector2 blockingPosition;
	private Vector2 punchingPosition;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		controller = GetComponent<PlayerController>();

		idlePosition = transform.position;

		float blockingX = idlePosition.x;
		float blockingY = idlePosition.y + 2f;
		blockingPosition = new Vector2(blockingX, blockingY);

		float punchingX = blockingX + (fistSide == FistSide.Left ? 2f : -2f);
		float punchingY = blockingY + 2f;
		punchingPosition = new Vector2(punchingX, punchingY);
	}
	
	// Update is called once per frame
	void Update () {
		switch (GetControlState()) {
		case PlayerController.ControlState.Punch:
			animator.SetInteger("AnimState", 2);
			transform.position = punchingPosition;
			break;
		case PlayerController.ControlState.Block:
			animator.SetInteger("AnimState", 1);
			transform.position = blockingPosition;
			break;
		case PlayerController.ControlState.Idle:
			animator.SetInteger("AnimState", 0);
			transform.position = idlePosition;
			break;
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
