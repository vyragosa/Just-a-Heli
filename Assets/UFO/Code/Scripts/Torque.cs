using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    #region Varaibles
    public float torqueSpeed = 2f;
    private Rigidbody rb;
    public Vector3 rotationDirection = new Vector3(0f, 1f, 0f);
    #endregion


    #region Buildin Methods

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (rb != null)
        {
            rb.AddTorque(Vector3.forward *  torqueSpeed);
        }
    }
    #endregion
}
