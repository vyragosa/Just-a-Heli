using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace JaH
{
    public class Heli_Camera : MonoBehaviour, IHeliCamera
    {
        #region Variables
        [Header("Basic Camera Properties")]
        public float height = 3.5f;
        public float distance = 6f;
        public Rigidbody rb;
        public Transform lookAtTarget;
        public float smoothSpeed = 0.35f;
        private Vector3 wantedPos;
        private Vector3 refVelocity;
        #endregion


        #region builtin Methods
        public void FixedUpdate()
        {
            if (rb != null)
            {
                UpdateCamera();
            }
        }
        #endregion

        #region Interface Methods
        public void UpdateCamera()
        {
            Vector3 flatfwd = transform.forward * -1;
            flatfwd.y = 0f;
            flatfwd = flatfwd.normalized;

            // wanted position
            wantedPos = rb.position + (flatfwd * distance) + (Vector3.up * height);


            // pos

            transform.position = Vector3.SmoothDamp(transform.position, wantedPos, ref refVelocity, smoothSpeed);
            transform.LookAt(lookAtTarget);


        }
        #endregion
    }
}