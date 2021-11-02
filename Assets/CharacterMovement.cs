using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float accel = 400.0F;
    public float maxWalkSpeed = 2.0F;
    public float maxRunSpeed = 3.0F;
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

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    anim. SetInteger("state", 5);
                    Debug.Log("5");
                }
                else
                {
                    if (vel.magnitude > maxRunSpeed)
                        rb.velocity = vel.normalized;
                    anim. SetInteger("state", 2);
                    Debug.Log("2");
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    anim. SetInteger("state", 5);
                    Debug.Log("5");
                }
                else
                {
                    if (vel.magnitude > maxWalkSpeed)
                        rb.velocity = vel.normalized;
                    anim. SetInteger("state", 1);
                    Debug.Log("1");
                }

            }
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    anim. SetInteger("state", 5);
                    Debug.Log("5");
                }
                else
                {
                    if (vel.magnitude > (maxRunSpeed/2))
                        rb.velocity = vel.normalized;
                    anim. SetInteger("state", 4);
                    Debug.Log("4");
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    anim. SetInteger("state", 5);
                    Debug.Log("5");
                }
                else
                {
                    if (vel.magnitude > (maxWalkSpeed/2))
                        rb.velocity = vel.normalized;
                    anim. SetInteger("state", 3);
                    Debug.Log("3");
                }
            }
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim. SetInteger("state", 5);
            Debug.Log("5");
        }
        else
        {
            anim. SetInteger("state", 0);
            Debug.Log("0");
        }
    }
}