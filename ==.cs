using System.IO;
using System;
namespace Day_2
{
        class Class9
        {
            static void Main()
            {
                object str = "helllo";
                char[] values = { 'h', 'e', 'l', 'l', 'o'};
                object str2 = new string(values);
                Console.WriteLine("Using equality operator {0}", str== str2);
                Console.WriteLine("using equals () method {0}" , str.Equals(str2));
                Console.ReadLine();
            }
        }
}