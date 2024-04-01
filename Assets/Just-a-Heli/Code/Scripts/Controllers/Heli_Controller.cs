using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class Heli_Controller : BaseRB_Controller
    {
        #region Variables
        [Header("Controller Properties")]
        public Input_Controller input;
        #endregion

        #region Custom Methods

        protected override void HandlePhysics()
        {
            if (input)
            {
                HandleEngines();
                HandleCharaceristics();
            }
            
        }

        protected virtual void HandleEngines()
        {

        }
        protected virtual void HandleCharaceristics()
        {

        }

        #endregion
    }

}
