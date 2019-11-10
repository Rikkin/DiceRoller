namespace Engine.Tools
{
    public class BaseMessageEventArgs : System.EventArgs
    {
        public string Message { get; private set; }

        public BaseMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}