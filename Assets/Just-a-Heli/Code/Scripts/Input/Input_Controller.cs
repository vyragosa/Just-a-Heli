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
    public class Input_Controller : MonoBehaviour
    {
        #region Variables
        public InputType inputType = InputType.Keyboard;

        [Header("Input Components")]
        public KeyboardHeli_Input keyInput;
        public XboxHeli_Input xboxInput;
        #endregion


        #region BuildIn Methods
        // Start is called before the first frame update
        void Start()
        {
            SetInputType(inputType);
        }
        #endregion

        #region Custom Methods
        void SetInputType(InputType type)
        {
            if (keyInput && xboxInput) 
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
        }
        #endregion

    }

}
