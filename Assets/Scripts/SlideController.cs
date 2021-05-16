using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class SlideController : MonoBehaviour
{
    
    [SerializeField] Button _nextButton;
    [SerializeField] Button _previousButton;
    [SerializeField] List<Slide> _slidesList;
    [SerializeField] SlideIndex _slideIndex;

    void Awake()
    {
        _nextButton.onClick.AddListener(ToNextSlide);
        _previousButton.onClick.AddListener(ToPreviousSlide);
    }


    void Start()
    {
        OpenSlideInIndex(_slideIndex.current);
    }

    public void ToNextSlide()
    {
        if (_slideIndex.current >= _slidesList.Count-1)
            return;
                
        _slidesList[_slideIndex.current].CloseSlide();
        _slideIndex.current++;
        _slidesList[_slideIndex.current].OpenSlide();

        CheckToDisableButtons();
    }

    public void ToPreviousSlide()
    {
        if (_slideIndex.current <= 0)
            return;
                
        _slidesList[_slideIndex.current].CloseSlide();
        _slideIndex.current--;
        _slidesList[_slideIndex.current].OpenSlide();
        
        CheckToDisableButtons();
        
    }
    
    void OpenSlideInIndex(int index)
    {
        if (_slideIndex.current < 0 || _slideIndex.current > _slidesList.Count)
        {
            Debug.LogError("INDEX DO SLIDE QUE ESTA TENTANDO ACESSAR ESTÁ FORA DOS LIMITES");
            return;
        }

        foreach (var slides in _slidesList)
        {
            slides.gameObject.SetActive(false);
        }

        _slidesList[index].OpenSlide();
        _slideIndex.current = index;
        
        CheckToDisableButtons();
    }

    void CheckToDisableButtons()
    {
        _previousButton.interactable = true;
        _nextButton.interactable = true;


        if (_slideIndex.current <= 0)
        {
            _previousButton.interactable = false;
        }

        if (_slideIndex.current >= _slidesList.Count - 1)
        {
            _nextButton.interactable = false;
        }
    }

}
