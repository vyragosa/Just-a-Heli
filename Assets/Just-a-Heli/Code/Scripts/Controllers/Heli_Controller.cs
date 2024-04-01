using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    [RequireComponent(typeof(Input_Controller))]
    public class Heli_Controller : BaseRB_Controller
    {
        #region Variables
        [Header("Controller Properties")]
        public List<Heli_Engine> engines = new List<Heli_Engine>();

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
            for (int i = 0; i < engines.Count; i++)
            {
                engines[i].UpdateEngine(input.TrottleInput);
            }
        }
        protected virtual void HandleCharaceristics()
        {

        }

        #endregion
    }

}
