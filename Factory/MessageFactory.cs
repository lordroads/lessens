namespace lessens{
    class MessageFactory : AbstractFactory
    {
        public override IMessage GetMessage(MessageType type, string text)
        {
            switch(type)
            {
                case MessageType.Error:
                    return new ErrorMessage(text);
                case MessageType.Info:
                    return new InfoMessage(text);
                case MessageType.Alert:
                    return new AlertMessage(text);
                default:
                    return null;
            }
        }
    }
}