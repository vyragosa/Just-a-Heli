using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class HeliTail_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Tail Rotor Properties")]
        public float rotationSpeedModifier = 1.5f;
        #endregion

        #region BuildIn methods
        // Start is called before the first frame update
        void Start()
        {

        }
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps)
        {
            transform.Rotate(Vector3.right, dps * rotationSpeedModifier);
            // Debug.Log("Updating Tail Rotor");
        }
        #endregion
    }

}
