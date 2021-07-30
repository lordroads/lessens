using System;
using System.Collections.Generic;

namespace lessens
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory _afactory = new MessageFactory();
            MessageFactory _mf = new MessageFactory();

            List<IMessage> messages = new List<IMessage>{
                _mf.GetMessage(MessageType.Info, "Test info message."),
                _mf.GetMessage(MessageType.Info, "Test info message.2"),
                _afactory.GetMessage(MessageType.Info, "You are Welcome Now..."),
                _afactory.GetMessage(MessageType.Alert, "Что то идет не так, как должно идти...типа Винимание!"),
                _afactory.GetMessage(MessageType.Error, "Все накрылось медным тазом!! =)) ")
            };

            foreach (IMessage message in messages)
            {
                ViewMessage.View(message);
            }
            
            /* IMessage testMessage = _mf.GetMessage(MessageType.Info, "Test info message.");
            var testMessage2 = _mf.GetMessage(MessageType.Info, "Test info message.2");
            ViewMessage.View(_factory.GetMessage(MessageType.Info, "You are Welcome Now..."));
            ViewMessage.View(_factory.GetMessage(MessageType.Alert, "Что то идет не так, как должно идти...типа Винимание!"));
            ViewMessage.View(_factory.GetMessage(MessageType.Error, "Все накрылось медным тазом!! =)) "));

            ViewMessage.View(testMessage);
            ViewMessage.View(testMessage2); */
            
            Console.ReadLine();
        }
    }
}
