using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCamera : MonoBehaviour
{
	public Transform target;
	public Vector3 offsetPosition;
	public Vector3 lookAtOffset;
	private Vector3 destinationPosition;
	private Vector3 currentPosition;
	public float smoothSpeed;
	public bool lookAt = true;

	private void Start()
	{
		transform.position = target. TransformPoint(offsetPosition);
		currentPosition = offsetPosition;
	}
	private void Update()
	{
		if(target == null)
		{
			Debug. LogWarning("Missing target ref !", this);
			return;
		}
		if(smoothSpeed < 0)
		{
			Debug. LogWarning("smoothSpeed < 0 !", this);
			return;
		}

		destinationPosition = offsetPosition + lookAtOffset;
		currentPosition = Vector3.Lerp(currentPosition, destinationPosition, smoothSpeed);
		transform.position = target. TransformPoint(currentPosition);

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