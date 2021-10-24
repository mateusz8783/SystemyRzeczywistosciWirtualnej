using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
	
	public Transform lookAtTarget;
	
	void FixedUpdate()
	{
		transform.LookAt(lookAtTarget.position);
	}
}
