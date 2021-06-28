using System;

namespace _2_способ_задачи_от_
{
    class Program
    {
        private static bool TryGetValue(out int val)
        {
            var t = Console.ReadLine();     
            bool r = !Int32.TryParse(t, out val);  
            return r;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел: "); 
            TryGetValue(out int x1);
            TryGetValue(out int x2);
            TryGetValue(out int x3);
            TryGetValue(out int x4);
            TryGetValue(out int x5);

           
            Console.WriteLine($"Запомните эти числа:{x1},{x2},{x3},{x4},{x5}");


            int[] Nums = { x1, x2, x3, x4, x5 };

            Console.WriteLine("Введите одно число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach(var num in Nums)
            {
                if (number== num)
                {
                    Console.WriteLine("Это оно!");
                }
                else
                {
                    Console.WriteLine("Это не оно!");
                }
            }







           
        }
    }
}
