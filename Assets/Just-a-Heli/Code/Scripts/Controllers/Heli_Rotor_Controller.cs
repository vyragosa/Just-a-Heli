using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using System.Linq;

namespace JaH
{
    public class Heli_Rotor_Controller : MonoBehaviour
    {
        #region Variables
        private List<IHeliRotor> rotors;
        #endregion

        #region BuildIn Methods
        private void Start()
        {
            rotors = GetComponentsInChildren<IHeliRotor>().ToList<IHeliRotor>();
        }
        #endregion

        #region Custom Methods
        public void updateRotors(Input_Controller input, float currentRPM)
        {
            // Debug.Log(currentRPM);
            
            // вычисление градусов в секунду
            float dps = ((currentRPM * 360f) / 60f) * Time.deltaTime;

            // обновление винтов 
            if (rotors.Count > 0)
            {
                foreach (var rotor in rotors)
                {
                    rotor.UpdateRotor(dps, input);
                }
            }
        }
        #endregion
    }

}
