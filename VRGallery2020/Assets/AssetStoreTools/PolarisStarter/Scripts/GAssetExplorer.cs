using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Pinwheel.PolarisStarter
{
    public class GAssetExplorer : MonoBehaviour
    {
        public static string PINWHEEL_ASSETS_LINK = "https://assetstore.unity.com/publishers/17305?aid=1100l3QbW&Pubref=polaris_1_starter_editor";
        public static string STYLIZED_VEGETATION_LINK = "https://assetstore.unity.com/lists/stylized-vegetation-120082?aid=1100l3QbW&Pubref=polaris_1_starter_editor";
        public static string STYLIZED_ROCK_PROPS_LINK = "https://assetstore.unity.com/lists/stylized-rock-props-120083?aid=1100l3QbW&Pubref=polaris_1_starter_editor";
        public static string STYLIZED_WATER_LINK = "https://assetstore.unity.com/lists/stylized-water-120085?aid=1100l3QbW&Pubref=polaris_1_starter_editor";
        public static string STYLIZED_SKY_AMBIENT_LINK = "https://assetstore.unity.com/lists/stylized-sky-and-ambient-120088?aid=1100l3QbW&Pubref=polaris_1_starter_editor";
        public static string STYLIZED_CHARACTER_LINK = "https://assetstore.unity.com/lists/stylized-character-120084?aid=1100l3QbW&Pubref=polaris_1_starter_editor";

        public static void ShowPinwheelAssets()
        {
            Application.OpenURL(PINWHEEL_ASSETS_LINK);
        }

        public static void ShowStylizedVegetationLink()
        {
            Application.OpenURL(STYLIZED_VEGETATION_LINK);
        }

        public static void ShowStylizedRockPropsLink()
        {
            Application.OpenURL(STYLIZED_ROCK_PROPS_LINK);
        }

        public static void ShowStylizedWaterLink()
        {
            Application.OpenURL(STYLIZED_WATER_LINK);
        }

        public static void ShowStylizedSkyAmbientLink()
        {
            Application.OpenURL(STYLIZED_SKY_AMBIENT_LINK);
        }

        public static void ShowStylizedCharacterLink()
        {
            Application.OpenURL(STYLIZED_CHARACTER_LINK);
        }
    }
}
