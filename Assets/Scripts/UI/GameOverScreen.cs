using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        ScreenButton.interactable = false;
    }

    public override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        ScreenButton.interactable = true;
    }
}
