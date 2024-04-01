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
