using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace JaH
{
    public class Keyboard_Input : BaseHeli_Input
    {
        #region Variables
        // [Header("Heli Keyboard Inputs")]
        #endregion

        #region Properties

        private float throttleInput = 0f;
        public float ThrottleInput
        {
            get { return throttleInput; }
        }

        private float collectiveInput = 0f;
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }

        private float cyclicInput = 0f;
        public float CyclicInput
        {
            get { return cyclicInput; }
        }

        private float pedalInput = 0f;
        public float PedalInput
        {
            get { return pedalInput; }
        }
        #region

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
