using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float hitDist;

    [SerializeField] LayerMask playerMask;
    [SerializeField] GameObject animatorCtlr;

    private Animator animator;

    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = animatorCtlr.GetComponent<Animator>();
    }

    void Update ()
    {
        PlayerMovement();

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
 
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity, playerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            if (hit.distance <= .5f)
                Debug.Log("hit");
            
        }
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (ver != 0)
        {
            //if (Input.GetKey("w"))
            //{
                animator.SetBool("JogForward", true);
            //}
        }
        else if (hor != 0)
        {
            animator.SetBool("JogForward", true);
        }
        else
        {
            animator.SetBool("JogForward", false);
        }

        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
         
            //isGrounded = false;
        }
    }
}