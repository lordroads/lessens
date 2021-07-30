using System;

namespace lessens{
    class ViewMessage{
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