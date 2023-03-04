namespace Delegate.Event.Example;

public class AccountEventArgs : EventArgs
{
    public string Message { get; set; }
    
    public AccountEventArgs(string message)
    {
        Message = message;
    }
}