using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class Rotor_Blur : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Roor Blur Properties")]
        public GameObject lRotor;
        public GameObject rRotor;
        public GameObject blurGeo;
        #endregion
        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            Debug.Log("Roor Blur updating");
        }
        #endregion

    }

}
