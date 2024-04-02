using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JaH
{
    public class Rotor_Blur : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Roor Blur Properties")]
        public float maxDPS = 100f;
        public List<GameObject> blades = new List<GameObject>();
        public GameObject blurGeo;


        public List<Texture2D> blureTextures = new List<Texture2D>();
        #endregion
        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            // Debug.Log("Roor Blur updating");
            float normalizedDPS = Mathf.InverseLerp(0f, maxDPS, dps);

            // вычисление текстуры по кадрам
            int blurTexID = Mathf.FloorToInt(normalizedDPS * blureTextures.Count - 1);
            blurTexID = Mathf.Clamp(blurTexID, 0, blureTextures.Count - 1);
        }
        #endregion

    }

}
