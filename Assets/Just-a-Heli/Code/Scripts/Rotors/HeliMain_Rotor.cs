using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class HeliMain_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Main Rotor Properties")]
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 35f;
        #endregion

        #region BuildIn methods
        // Start is called before the first frame update
        void Start()
        {

        }
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            // вращение лопастей
            // Debug.Log(dps);
            transform.Rotate(Vector3.up, dps);

            // наклон лопастей 
            if(lRotor && rRotor)
            {
                Debug.Log(input.StickyCollective);
                lRotor.localRotation = Quaternion.Euler(-input.StickyCollective * maxPitch, 0f, 0f);
                rRotor.localRotation = Quaternion.Euler(input.StickyCollective * maxPitch, 0f, 0f);
            }
        }
        #endregion
    }

}
