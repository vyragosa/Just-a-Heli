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
            // �������� ��������
            // Debug.Log("Updating Main Rotor");
            transform.Rotate(Vector3.up, dps);

            // ������ �������� 
            if(lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(input.CollectiveInput * maxPitch, 0f, 0f);
                rRotor.localRotation = Quaternion.Euler(-input.CollectiveInput * maxPitch, 0f, 0f);
            }
        }
        #endregion
    }

}
