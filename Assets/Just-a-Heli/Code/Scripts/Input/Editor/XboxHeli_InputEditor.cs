using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace JaH
{
    [CustomEditor(typeof(XboxHeli_Input))]
    public class XboxHeli_InputEditor : Editor
    {
        #region Variables
        XboxHeli_Input targetInput;
        #endregion

        #region BuildIn Methods
        private void OnEnable()
        {
            targetInput = (XboxHeli_Input)target;
        }


        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DrawDebugUI();
            Repaint();
        }
        #endregion

        #region Custom Methods
        void DrawDebugUI()
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.Space();

            EditorGUI.indentLevel++;
            EditorGUILayout.LabelField("Throttle:\t" + targetInput.ThrottleInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Collective:\t" + targetInput.CollectiveInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Cyclic:\t\t" + targetInput.CyclicInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Pedal:\t\t" + targetInput.PedalInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUI.indentLevel--;

            EditorGUILayout.EndVertical();
        }
        #endregion
    }
}
