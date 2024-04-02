using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class HeliTail_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Tail Rotor Properties")]
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 45f;
        public float rotationSpeedModifier = 1.5f;
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
            transform.Rotate(Vector3.right, dps * rotationSpeedModifier);
            // Debug.Log("Updating Tail Rotor");


            // наклон лопастей 
            if (lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(0f, input.PedalInput * maxPitch, 0f);
                rRotor.localRotation = Quaternion.Euler(0f, -input.PedalInput * maxPitch, 0f);
            }
        }
        #endregion
    }

}
