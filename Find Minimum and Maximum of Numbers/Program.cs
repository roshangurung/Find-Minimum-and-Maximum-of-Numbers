using System;

namespace Find_Minimum_and_Maximum_of_Numbers
{
    class Program///This C# program is used to find minimum and maximum of numbers. Using array1 variable we have already defined the values, hence the minimum and the maximum number are obtained with the help of min and max functions.///
    {
        static void Main()
        {
            int[] array1 = { 10, -10, -20, 0, 15, 20, 30 };
            Console.WriteLine("Maximum Element : " + array1.Max());
            Console.WriteLine("Minimum Element : " + array1.Min());
            Console.Read();
        }
    }
}
///Output:
///Maximum Element:30
///Minimum Element:-20
