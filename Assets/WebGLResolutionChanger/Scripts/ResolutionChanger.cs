using System.Runtime.InteropServices;
using UnityEngine;

namespace WebGLResolutionChanger
{
    public class ResolutionChanger : MonoBehaviour
    {
#if UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void SetCanvasResolutionJS(int width, int height);
#endif

        public static void SetCanvasResolution(int width, int height)
        {
#if UNITY_WEBGL
            SetCanvasResolutionJS(width, height);
#else
            Screen.SetResolution(width, height, false);
#endif
        }

    }
}