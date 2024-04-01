using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class Keyboard_Input : BaseHeli_Input
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        public float throttleInput = 0f;
        public float collectiveInput = 0f;
        public float cyclicInput = 0f;
        public float pedalInput = 0f;
        #endregion

        #region BuildIn Methods
        #endregion

        #region Custom Methods
        protected override void HandleInputs()
        {
            base.HandleInputs();
            throttleInput = vertical;
            pedalInput = horizontal;
        }
        #endregion
    }

}
