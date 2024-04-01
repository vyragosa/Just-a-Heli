using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public enum InputType
    {
        Keyboard,
        Xbox,
    }
    [RequireComponent(typeof(KeyboardHeli_Input), typeof(XboxHeli_Input))]
    public class Input_Controller : MonoBehaviour
    {
        #region Variables
        [Header("Input Properties")]
        public InputType inputType = InputType.Xbox;

        private KeyboardHeli_Input keyInput;
        private XboxHeli_Input xboxInput;

        private float throttleInput;
        public float TrottleInput
        {
            get { return throttleInput; }
        }

        private float collectiveInput;
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }

        private Vector2 cyclicInput;
        public Vector2 CyclicInput
        {
            get { return cyclicInput; }
        }

        private float pedalInput;
        public float PedalInput
        {
            get { return pedalInput; }
        }
        #endregion


        #region BuildIn Methods
        // Start is called before the first frame update
        void Start()
        {
            keyInput = GetComponent<KeyboardHeli_Input>();
            xboxInput = GetComponent<XboxHeli_Input>();
            if (keyInput && xboxInput)
            {
                SetInputType(inputType);
            }
        }

        private void Update()
        {
            if (keyInput && xboxInput)
            {
                switch (inputType)
                {
                    case InputType.Keyboard:
                        throttleInput = keyInput.ThrottleInput;
                        collectiveInput = keyInput.CollectiveInput;
                        cyclicInput = keyInput.CyclicInput;
                        pedalInput = keyInput.PedalInput;
                        break;

                    case InputType.Xbox:
                        throttleInput = xboxInput.ThrottleInput;
                        collectiveInput = xboxInput.CollectiveInput;
                        cyclicInput = xboxInput.CyclicInput;
                        pedalInput = xboxInput.PedalInput;
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion

        #region Custom Methods
        void SetInputType(InputType type)
        {
            if (inputType == InputType.Keyboard)
            {
                keyInput.enabled = true;
                xboxInput.enabled = false;
            }

            if (inputType == InputType.Xbox)
            {
                xboxInput.enabled = true;
                keyInput.enabled = false;
            }  
        }
        #endregion

    }

}
