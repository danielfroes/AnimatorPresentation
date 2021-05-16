using UnityEngine;
using UnityEngine.Events;

public class Slide : MonoBehaviour
{
    [SerializeField] UnityEvent OnSlideOpen;
    [SerializeField] UnityEvent OnSlideClose;


    public void OpenSlide()
    {
        OnSlideOpen.Invoke();
        gameObject.SetActive(true);
    }

    public void CloseSlide()
    {
        OnSlideClose.Invoke();
        gameObject.SetActive(false);
    }
}
