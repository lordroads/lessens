namespace lessens{
    abstract class AbstractFactory{
        public abstract IMessage GetMessage(MessageType type, string text);
    }
}