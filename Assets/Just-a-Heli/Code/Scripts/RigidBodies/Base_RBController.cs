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
        #endregion


        #region BuiltIn Methods
        // Use this for initialization
        public virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
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
