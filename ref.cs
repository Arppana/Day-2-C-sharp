using System;

class Class2
{
    class Program
    {
        void swap(ref int a, refint b)
        {
            int temp = a;
            a=b;
            b=temp;
            Console.WriteLine("------inside swap function------");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
        }
        static void Main()
        {
            Class2 class1= new Class2();
            int a=5, b=6;
            class1.Swap(ref a,ref b);
            Console.WriteLine("------OUTSIDE swap function------");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
            Console.ReadLine();
        }
    }
}