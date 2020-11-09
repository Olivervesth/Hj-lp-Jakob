using System;

namespace Hjælp_jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jacob your program looks alot better now :D!\nI made you a quick test here by sending the message: this is a test message");
            Message send = new Message("This","Is","A","Test","Message");
            MessageHandler message = new MessageHandler();
            message.SendMessage(MessageCarrier.Type.VMessage,send,true);
            Console.WriteLine("And It Works! D:");
            Console.ReadKey();
        }
    }
}
