
namespace testEvent;
 class ButttonMaster
 {
    public event EventHandler<ButtonPressedEventArgs> ButtonPressed;
    public virtual void OnButtonPressed(Char keyCode)
    {
        ButtonPressed?.Invoke(this, new ButtonPressedEventArgs(keyCode));   
    }


}


public class ButtonPressedEventArgs
{
    public ButtonPressedEventArgs(char keyCode)
    {
        KeyCode = keyCode;
    }

    public char KeyCode { get; }
}

