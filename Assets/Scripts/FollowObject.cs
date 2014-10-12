using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {
	public Vector2 offset;
	public Transform following;

	// Update is called once per frame
	void Update () {
		transform.position = following.transform.position + (Vector3) offset;
	}
}
