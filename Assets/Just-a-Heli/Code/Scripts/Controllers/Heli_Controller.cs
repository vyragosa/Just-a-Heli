using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    [RequireComponent(typeof(Input_Controller))]
    public class Heli_Controller : BaseRB_Controller
    {
        #region Variables
        [Header("Helicopter Properties")]
        public List<Heli_Engine> engines = new List<Heli_Engine>();

        [Header("Helicopter Rotors")]
        public Heli_Rotor_Controller rotorCtrl;
        private Input_Controller input;
        #endregion


        #region Custom Methods

        protected override void HandlePhysics()
        {
            input = GetComponent<Input_Controller>();
            if (input)
            {
                HandleEngines();
                HandleRotors();
                HandleCharaceristics();
            }
            
        }

        #endregion


        #region Helicopter Controle Methods
        protected virtual void HandleEngines()
        {
            for (int i = 0; i < engines.Count; i++)
            {
                engines[i].UpdateEngine(input.StickyThrottle);
                float finalPower = engines[i].CurrentHP;
                // Debug.Log(finalPower);
            }
        }

        protected virtual void HandleRotors()
        {
            if (rotorCtrl != null && engines.Count > 0)
            {
                rotorCtrl.updateRotors(input, engines[0].CurrentRPM);
            }
        }

        protected virtual void HandleCharaceristics()
        {

        }

        #endregion
    }

}
