using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    public static class EditorSlideShortcuts
    {
        
        [MenuItem("SlideShow/Pass To Next Slide %RIGHT")]
        static void PassToNextSlide()
        {
            var slideController = Object.FindObjectOfType<SlideController>();
            slideController.ToNextSlide();
        }
        
        
        [MenuItem("SlideShow/GoToPreviousSlide %LEFT")]
        static void PassToPreviousSlide()
        {
            var slideController = Object.FindObjectOfType<SlideController>();
            slideController.ToPreviousSlide();
        }

    }
}