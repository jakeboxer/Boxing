using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {
	public enum FistSide { Left, Right };

	public FistSide fistSide;

	private Animator animator;
	private FighterController controller;
	private DealDamage dealDamage;

	private Vector2 idlePosition;
	private Vector2 blockingPosition;
	private Vector2 punchingPosition;

	void Awake () {
		idlePosition = transform.position;
		
		float blockingX = idlePosition.x;
		float blockingY = idlePosition.y + 2f;
		blockingPosition = new Vector2(blockingX, blockingY);
		
		float punchingX = blockingX + (fistSide == FistSide.Left ? 2f : -2f);
		float punchingY = blockingY + 2f;
		punchingPosition = new Vector2(punchingX, punchingY);
	}

	void Start () {
		animator = GetComponent<Animator>();
		controller = GetComponent<FighterController>();
		dealDamage = GetComponentInParent<DealDamage>();
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

	FighterController.ControlState GetControlState () {
		if (fistSide == FistSide.Left) {
			return controller.leftControlState;
		} else {
			return controller.rightControlState;
		}
	}

	void OnPunch () {
		dealDamage.Fire();
	}
}
