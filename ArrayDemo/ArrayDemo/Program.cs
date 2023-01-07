﻿namespace Arraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new [] { 3, 7, 9, 2, 14, 6 };
            // Length
            Console.WriteLine("length: " + numbers.Length);

            // index of ()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);

            // Clear ()
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);
            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy ()");
            foreach(var n in another)
                Console.WriteLine(n);

            // Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort ()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            // Reverse ()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Copy ()");
            foreach (var n in numbers)
                Console.WriteLine(n);


        }
    }
}