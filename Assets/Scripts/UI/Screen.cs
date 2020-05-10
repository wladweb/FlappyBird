using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public abstract class Screen : MonoBehaviour
{
    [SerializeField] protected Button ScreenButton;
    [SerializeField] protected CanvasGroup CanvasGroup;

    private void OnEnable()
    {
        ScreenButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        ScreenButton.onClick.RemoveListener(OnButtonClick);
    }

    public abstract void OnButtonClick();
    public abstract void Open();
    public abstract void Close();
}
