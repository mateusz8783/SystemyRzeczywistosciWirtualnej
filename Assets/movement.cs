﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float speed=300;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
			float horizontal = Input.GetAxis("Horizontal");
			float vertical = Input.GetAxis("Vertical");
			
			Vector3 direction = new Vector3(horizontal,0,vertical);
			
			rb.AddForce(direction * speed * Time.deltaTime);
	}
}
