using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    [RequireComponent(typeof(Input_Controller), typeof(KeyboardHeli_Input), typeof(XboxHeli_Input))]
    public class Heli_Controller : BaseRB_Controller
    {
        #region Variables
        // [Header("Controller Properties")]
        private Input_Controller input;
        #endregion

        #region Custom Methods

        protected override void HandlePhysics()
        {
            input = GetComponent<Input_Controller>();
            if (input)
            {
                HandleEngines();
                HandleCharaceristics();
            }
            
        }

        #endregion


        #region Helicopter Controle Methods
        protected virtual void HandleEngines()
        {

        }
        protected virtual void HandleCharaceristics()
        {

        }

        #endregion
    }

}
