using System;
namespace Incrementing
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            num2 = ++num1;
            Console.WriteLine(num2);
            num2 = num1++;
            Console.WriteLine(num2);
            num2 = num1++;
            Console.WriteLine(num2);
            //swapping
            int temp;
            temp = num1;
            num1 = num2;
            num2= temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
