using System;

namespace lessens{
    class ViewMessage{
        
        ///<summary>
        ///Метод декорирует и выводит сообщения в консоль
        ///</summary>
        ///<param name="message"> Необходимо передать сообщение реализующие контракт с интерфейсом IMessage </param>
        public static void View(IMessage message){
            if(message is ErrorMessage){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message.GetText());
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(message is AlertMessage){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message.GetText());
                Console.ForegroundColor = ConsoleColor.White;
            }
            else{
                Console.WriteLine(message.GetText());
            }
        }
    }
}