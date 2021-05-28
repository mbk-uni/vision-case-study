using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class PlayerController : MonoBehaviour
{
    public float sidewayForce = 500;

    private Rigidbody rb;
    private Animator animator;

    public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!animator.GetBool("jump"))
        {
            SidewayControl();
        }
        
        JumpAnimation();

        
        
    }

    public void Running()
    {
        animator.SetBool("jump", false);
    }

    private void SidewayControl()
    {
        if (joystick.Horizontal > 0.2)
        {
            if (transform.position.x < 4.5f)
            {
                rb.MovePosition(transform.position + new Vector3(sidewayForce * Time.deltaTime, 0, 0));
            }

        }

        if (joystick.Horizontal < -0.2)
        {
            if (transform.position.x > -4.5f)
            {
                rb.MovePosition(transform.position + new Vector3(-sidewayForce * Time.deltaTime, 0, 0));
            }

        }
    }

    private void JumpAnimation()
    {
        if(joystick.Vertical > 0.5f)
        {
            animator.SetBool("jump", true);

        }
    }
}
