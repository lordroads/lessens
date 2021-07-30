namespace lessens{
    abstract class AbstractFactory{

        ///<summary>
        ///Фабричный метод возращающий объект реализующий контракт с интерфейсом IMessage
        ///</summay>
        ///<param name="type"> Задает тип сообщения адресации конкретной группе пользователей</param>
        ///<param name="text"> Текст сообщения</param>
        public abstract IMessage GetMessage(MessageType type, string text);
    }
}