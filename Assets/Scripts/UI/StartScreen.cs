using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        ScreenButton.interactable = false;
    }

    public override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        ScreenButton.interactable = true;
    }
}
