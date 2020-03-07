using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Pinwheel.PolarisStarter
{
    [CustomEditor(typeof(IslandGenerator))]
    public class IslandGeneratorEditor : Editor
    {
        //private IslandGenerator instance;
        private static GUIStyle subTitleStyle;
        private static GUIStyle SubTitleStyle
        {
            get
            {
                if (subTitleStyle == null)
                {
                    subTitleStyle = new GUIStyle(EditorStyles.label);
                    subTitleStyle.fontSize = 13;
                    subTitleStyle.alignment = TextAnchor.MiddleCenter;
                    subTitleStyle.fontStyle = FontStyle.Bold;
                    subTitleStyle.normal.textColor = Color.white;
                }
                return subTitleStyle;
            }
        }

        private Texture2D goProBanner;
        private Texture2D GoProBanner
        {
            get
            {
                if (goProBanner == null)
                {
                    goProBanner = Resources.Load<Texture2D>("GoProBanner");
                }
                return goProBanner;
            }
        }

        private Texture2D basicEditionBanner;
        private Texture2D BasicEditionBanner
        {
            get
            {
                if (basicEditionBanner == null)
                {
                    basicEditionBanner = Resources.Load<Texture2D>("BasicEditionBanner");
                }
                return basicEditionBanner;
            }
        }

        private Texture2D polarisV2Banner;
        private Texture2D PolarisV2Banner
        {
            get
            {
                if (polarisV2Banner == null)
                {
                    polarisV2Banner = Resources.Load<Texture2D>("PolarisV2AdsImage");
                }
                return polarisV2Banner;
            }
        }

        private void OnEnable()
        {
            //instance = (IslandGenerator)target;
        }

        public override void OnInspectorGUI()
        {
            if (GoProBanner != null)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                Rect r = EditorGUILayout.GetControlRect(GUILayout.Width(256), GUILayout.Height(64));
                if (GUI.Button(r, "", GUIStyle.none))
                {
                    Application.OpenURL(VersionInfo.ProVersionLink);
                }
                EditorGUI.DrawTextureTransparent(r, GoProBanner, ScaleMode.ScaleToFit);
                EditorGUILayout.EndHorizontal();
                EditorGUIUtility.AddCursorRect(r, MouseCursor.Link);
            }
            
            if (BasicEditionBanner != null)
            {
                EditorGUILayout.Space();
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                Rect r = EditorGUILayout.GetControlRect(GUILayout.Width(256), GUILayout.Height(64));
                if (GUI.Button(r, "", GUIStyle.none))
                {
                    Application.OpenURL(VersionInfo.BasicVersionLink);
                }
                EditorGUI.DrawTextureTransparent(r, BasicEditionBanner, ScaleMode.ScaleToFit);
                EditorGUILayout.EndHorizontal();
                EditorGUIUtility.AddCursorRect(r, MouseCursor.Link);
            }

            if (PolarisV2Banner != null)
            {
                EditorGUILayout.Space();
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                Rect r = EditorGUILayout.GetControlRect(GUILayout.Width(256), GUILayout.Height(64));
                if (GUI.Button(r, "", GUIStyle.none))
                {
                    Application.OpenURL("https://assetstore.unity.com/packages/tools/terrain/polaris-v2-ultimate-low-poly-terrain-engine-144645?aid=1100l3QbW&pubref=editor-ads");
                }
                EditorGUI.DrawTextureTransparent(r, PolarisV2Banner, ScaleMode.ScaleAndCrop);
                EditorGUILayout.EndHorizontal();
                EditorGUIUtility.AddCursorRect(r, MouseCursor.Link);

                EditorGUI.DropShadowLabel(r, "Polaris V2 is here!", SubTitleStyle);
            }

            EditorGUILayout.Space();

            base.OnInspectorGUI();
        }
    }
}