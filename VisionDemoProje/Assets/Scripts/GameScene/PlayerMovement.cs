using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 1000;
    private Quaternion rotationConstraint;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotationConstraint = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0,0, forwardForce * Time.deltaTime);
        
        transform.rotation = rotationConstraint;

        
    }

    
}
