using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class HeliMain_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
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
            // Debug.Log("Updating Main Rotor");
            transform.Rotate(Vector3.up, dps);

        }
        #endregion
    }

}
