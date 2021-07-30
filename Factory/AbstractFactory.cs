namespace lessens{
    abstract class AbstractFactory{
        public abstract IMassage GetMessage(MessageType type, string text);
    }
}