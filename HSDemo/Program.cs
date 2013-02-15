using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HSDemo.Utils;
using HSDemo.Framework;

namespace HSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionay and add two keyvaluepairs to hold the number-to-message configuration.
            var dicNumberToMessage = new Dictionary<int, string>();
            dicNumberToMessage.Add(2, "Message for number two.");
            dicNumberToMessage.Add(3, "Message for number three.");
            dicNumberToMessage.Add(8, "Message for number eigth.");

            var objNumberGenerator = new NumberGenerator();
            objNumberGenerator.GenerateNumberList(dicNumberToMessage, 0, 200);
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        
        }
    }
}
