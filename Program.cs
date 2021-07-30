using System;

namespace lessens
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory _factory = new MessageFactory();
            ViewMessage.View(_factory.GetMessage(MessageType.Info, "You are Welcome Now..."));
            ViewMessage.View(_factory.GetMessage(MessageType.Alert, "Что то идет не так, как должно идти...типа Винимание!"));
            ViewMessage.View(_factory.GetMessage(MessageType.Error, "Все накрылось медным тазом!! =)) "));
            Console.ReadLine();
        }
    }
}
