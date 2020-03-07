using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace Pinwheel.PolarisStarter
{
    [CustomEditor(typeof(GAssetExplorer))]
    public class GAssetExplorerInspector : Editor
    {
        private GAssetExplorer instance;

        private static string INSTRUCTION = string.Format("Below are some asset suggestions which we found helpful to enhance your scene.");

        public void OnEnable()
        {
            instance = target as GAssetExplorer;
        }

        public override void OnInspectorGUI()
        {
            DrawInstructionGUI();
            DrawCollectionsGUI();
            DrawCrossPromotionGUI();
        }

        private void DrawInstructionGUI()
        {
            string prefKey = EditorCommon.GetProjectRelatedEditorPrefsKey("foldout", "assetexplorerinstruction", instance.GetInstanceID().ToString());
            bool expanded = EditorPrefs.GetBool(prefKey, true);
            expanded = EditorGUILayout.Foldout(expanded, "Instruction");
            EditorPrefs.SetBool(prefKey, expanded);

            if (expanded)
            {
                EditorGUILayout.LabelField(INSTRUCTION, EditorCommon.WordWrapLeftLabel);
                EditorGUILayout.Space();
            }
        }

        private void DrawCollectionsGUI()
        {
            string prefKey = EditorCommon.GetProjectRelatedEditorPrefsKey("foldout", "assetexplorercollections", instance.GetInstanceID().ToString());
            bool expanded = EditorPrefs.GetBool(prefKey, true);
            expanded = EditorGUILayout.Foldout(expanded, "Collections");
            EditorPrefs.SetBool(prefKey, expanded);

            if (expanded)
            {
                Rect r;
                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Other Assets From Pinwheel"))
                {
                    GAssetExplorer.ShowPinwheelAssets();
                }

                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Stylized Vegetation"))
                {
                    GAssetExplorer.ShowStylizedVegetationLink();
                }

                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Stylized Rock & Props"))
                {
                    GAssetExplorer.ShowStylizedRockPropsLink();
                }

                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Stylized Water"))
                {
                    GAssetExplorer.ShowStylizedWaterLink();
                }

                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Stylized Sky & Ambient"))
                {
                    GAssetExplorer.ShowStylizedSkyAmbientLink();
                }

                r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Stylized Character"))
                {
                    GAssetExplorer.ShowStylizedCharacterLink();
                }

                EditorGUILayout.Space();
            }
        }

        private void DrawCrossPromotionGUI()
        {
            string prefKey = EditorCommon.GetProjectRelatedEditorPrefsKey("foldout", "assetexplorercrosspromotion", instance.GetInstanceID().ToString());
            bool expanded = EditorPrefs.GetBool(prefKey, false);
            expanded = EditorGUILayout.Foldout(expanded, "Cross Promotion");
            EditorPrefs.SetBool(prefKey, expanded);

            if (expanded)
            {
                string text = "Are you a Publisher, send us a message to get more expose to the community!";
                EditorGUILayout.LabelField(text, EditorCommon.WordWrapLeftLabel);
                Rect r = EditorGUILayout.GetControlRect();
                if (GUI.Button(r, "Send an Email"))
                {
                    EditorCommon.OpenEmailEditor(
                        "hello@pinwheel.studio",
                        "[Polaris] CROSS PROMOTION",
                        "DETAIL ABOUT YOUR ASSET HERE");
                }

                EditorGUILayout.Space();
            }
        }
    }
}
