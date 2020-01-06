using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            String message = "";
            int checksum = 0;
            char ch;
            int num;
            Console.WriteLine("What is your message?");
            input = Console.ReadLine();
            input = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                ch = input[i];
                num = (int)ch;
                checksum = checksum + num;
                message = message + num.ToString() + "-";
            }
            message = message.Remove(message.Length - 1);
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("The message checksum is " + checksum);
            

        }
    }
}
