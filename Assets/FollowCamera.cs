using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCamera : MonoBehaviour
{
	public Transform target;
	public Vector3 offsetPosition;
	public Vector3 lookAtOffset;
	public float smoothSpeed;
	public bool lookAt = true;

	private void Update()
	{
		if(target == null)
		{
			Debug.LogWarning("Missing target ref !", this);
			return;
		}

		transform.position = Vector3.Lerp(transform.position, offsetPosition + lookAtOffset, smoothSpeed);

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