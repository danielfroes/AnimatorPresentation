using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionSlideController : MonoBehaviour
{
    [SerializeField] Animator _animator;

    [SerializeField] Button _punchButton;
    [SerializeField] Button _jumpButton;
    [SerializeField] Toggle _walkingToggle;

    public void Start()
    {
        _punchButton.onClick.AddListener(PunchButtonCallback);
        _jumpButton.onClick.AddListener(JumpButtonCallback);
        _walkingToggle.onValueChanged.AddListener(WalkingToggleCallback);
    }

    void PunchButtonCallback()
    {
        _animator.SetTrigger("punch");
    }
    
    void JumpButtonCallback()
    {
        _animator.SetTrigger("jump");
    }
    
    void WalkingToggleCallback(bool status)
    {
        _animator.SetBool("walking", status);
    }
}
