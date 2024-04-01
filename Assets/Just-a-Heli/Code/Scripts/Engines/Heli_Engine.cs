using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class Heli_Engine : MonoBehaviour
    {
        #region Variables
        public float maxHP = 140f;
        public float maxRPM = 2700;
        public float powerDelay = 2f;
        public AnimationCurve powerCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));
        #endregion

        #region Properties
        private float currentHP;
        public float CurrentHP
        {
            get { return currentHP; }
        }

        private float currentRPM;
        public float CurrentRPM
        {
            get { return currentRPM; }
        }

        #endregion

        #region BuildIn methods
        // Start is called before the first frame update
        void Start()
        {

        }


        #endregion

        #region Custom Methods
        public void UpdateEngine(float throttleInput)
        {
           // Вычисление лошадиных сил
           float wantedHP = powerCurve.Evaluate(throttleInput) * maxHP;
           currentHP = Mathf.Lerp(currentHP, wantedHP, Time.deltaTime * powerDelay);

            //Вычисление оборотов в минуту
            float wantedRPM = throttleInput * maxRPM;
            currentRPM = Mathf.Lerp(currentRPM, wantedRPM, Time.deltaTime * powerDelay);

        }
        #endregion
    }

}
