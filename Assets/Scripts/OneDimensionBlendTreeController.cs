using UnityEngine;
using UnityEngine.UI;

public class OneDimensionBlendTreeController : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] Slider _slider;

    void Start()
    {
        _slider.onValueChanged.AddListener(value =>
        {
            _animator.SetFloat("velocity", value);
        } );
    }
}
