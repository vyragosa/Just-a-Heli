using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    #region Variables
    public float maxSpeed = 1f;
    private Rigidbody rb;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);
    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(rb)
        {
            rb.AddForce(movementDirection * maxSpeed);
        }
    }

}
