namespace lessens{
    class MessageFactory : AbstractFactory
    {

        ///<summary>
        ///Фабричный метод возращающий объект реализующий контракт с интерфейсом IMessage
        ///</summay>
        ///<param name="type"> Задает тип сообщения адресации конкретной группе пользователей</param>
        ///<param name="text"> Текст сообщения</param>
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