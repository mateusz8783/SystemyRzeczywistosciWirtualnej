using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCamera : MonoBehaviour
{
	public Transform target;
	public Vector3 offsetPosition;
	public bool lookAt = true;
	private void Update()
	{
		if(target == null)
		{
			Debug. LogWarning("Missing target ref !", this);
			return;
		}
		transform.position = target. TransformPoint(offsetPosition);

		// compute rotation
		if(lookAt)
		{
			transform.LookAt(target);
		}
		else
		{
			transform.rotation = target.rotation;
		}
	}
}