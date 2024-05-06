using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    [RequireComponent(typeof(Rigidbody))]
    public class BaseRB_Controller : MonoBehaviour
    {
        #region Variables
        [Header("Base Properties")]
        protected Rigidbody rb;
        public float weight = 635f;
        public Transform cog;
        #endregion


        #region BuiltIn Methods
        // Use this for initialization
        public virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.mass = weight; 
            }
        }


        // Update is called once per frame
        void FixedUpdate()
        {
            if (rb)
            {
                HandlePhysics();
            }
        }
        #endregion


        #region Custom Methods
        protected virtual void HandlePhysics() { }
        #endregion
    }
}
