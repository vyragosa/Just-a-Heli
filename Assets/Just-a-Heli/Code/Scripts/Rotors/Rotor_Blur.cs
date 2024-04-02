using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace JaH
{
    public class Rotor_Blur : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Roor Blur Properties")]
        public float maxDPS = 30f;
        public List<GameObject> blades = new List<GameObject>();
        public GameObject blurGeo;


        public List<Texture2D> blureTextures = new List<Texture2D>();
        public Material blurMat;
        #endregion
        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            // Debug.Log("Roor Blur updating");
            float normalizedDPS = Mathf.InverseLerp(0f, maxDPS, dps);

            // вычисление текстуры по кадрам
            int blurTexID = Mathf.FloorToInt(normalizedDPS * blureTextures.Count - 1);
            blurTexID = Mathf.Clamp(blurTexID, 0, blureTextures.Count - 1);

            if(blurMat && blureTextures.Count > 0 )
            {
                blurMat.SetTexture("_MainTex", blureTextures[blurTexID]);
            }

            if (blurTexID > 2 && blades.Count > 0) 
            {
                HandleGeoBladeViz(false);
            }
            else
            {
                HandleGeoBladeViz(true);
            }
        }
        #endregion

        #region Custom Methods
        void HandleGeoBladeViz(bool viz)
        {
            foreach (var blade in blades)
            {
                blade.SetActive(viz);
            }
        }
        #endregion


    }

}
