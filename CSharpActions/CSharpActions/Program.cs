using System;

namespace CSharpActions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<IMessage> messageTarget = WriteMessage;
            IMessage msg = new MyMessage() { Message = "Hello, World!", HaveDisplayed = false };

            messageTarget(msg);

            if (msg.HaveDisplayed)
                Console.WriteLine("Displayed Message.");

            Console.ReadKey();
        }

        private static void WriteMessage(IMessage message)
        {
            Console.WriteLine(message.Message);
            message.HaveDisplayed = true;
        }
    }

    internal class MyMessage : IMessage
    {
        public string Message { get; set; }
        public bool HaveDisplayed { get; set; }
    }

    internal interface IMessage
    {
        string Message { get; set; }
        bool HaveDisplayed { get; set; }
    }
}