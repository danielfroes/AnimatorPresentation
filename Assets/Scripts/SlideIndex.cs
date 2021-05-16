using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "new Index", menuName = "Assets/SlidesIndex", order = 0)]
    public class SlideIndex : ScriptableObject
    {
        public int current;
    }
}