using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public const int IDLE = 0;
	public const int BLOCKING = 1;
	public const int PUNCHING = 2;

	public int leftHandState = IDLE;
	public int rightHandState = IDLE;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("'")) {
			rightHandState = PUNCHING;
		} else if (Input.GetKey("/")) {
			rightHandState = BLOCKING;
		} else {
			rightHandState = IDLE;
		}
	}
}
