using UnityEngine;
using UnityEngine.UI;

namespace WebGLResolutionChanger.Sample
{
    public class SampleResolutionChanger : MonoBehaviour
    {
        public void OnChangeResolution256x144()
        {
            OnChangeResolution(256, 144);
        }

        public void OnChangeResolution1179x2556()
        {
            OnChangeResolution(1179, 2556);
        }

        public void OnChangeResolution750x1334()
        {
            OnChangeResolution(750, 1334);
        }

        public void OnChangeResolution2048x2732()
        {
            OnChangeResolution(2048, 2732);
        }

        
        private void OnChangeResolution(int width, int height)
        {
            Debug.Log($"int width={width}, int height={height}");
            ResolutionChanger.SetCanvasResolution(width, height);
        }
    }
}