using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float accel = 400.0F;
    public float maxSpeed = 2.0F;
    public float rotateSpeed = 2.0F;
    private Vector3 moveDirection = Vector3.zero;
    public Animator anim;

    // Update is called once per frame
    void FixedUpdate()
    {
        moveDirection = new Vector3(0,0, Input.GetAxis ("Vertical"));
        moveDirection = transform. TransformDirection (moveDirection);
        moveDirection *= accel;

        rb.AddForce (moveDirection* Time.deltaTime);
        //Rotate Player
        transform.Rotate(0, Input.GetAxis ("Horizontal")*rotateSpeed, 0);

        Vector3 vel = rb.velocity;
        if (vel.magnitude > maxSpeed)
            rb.velocity = vel.normalized;
        if (vel.magnitude > 0.0F)
            anim.SetBool("isWalking", true);
        else
            anim. SetBool("isWalking", false);
    }
}