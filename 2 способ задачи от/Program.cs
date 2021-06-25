using System;

namespace _2_способ_задачи_от_
{
    class Program
    {
        private static bool TryGetValue(out int val)
        {
            Console.WriteLine("Введите 5 чисел: ");
            var t = Console.ReadLine();
            var r = int.TryParse(t, out val);
            return r;
        }

        static void Main(string[] args)
        {
            

            if (!r)
            {
                Console.WriteLine("Вы ввели не число!");
            }          



            int x1 = Convert.ToInt32();






            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int x5 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Запомните эти числа:{x1},{x2},{x3},{x4},{x5}");

            int[] Nums = { x1, x2, x3, x4, x5 };
            Console.WriteLine("Введите одно число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach(var num in Nums)
            {
                if (number== num)
                {
                    Console.WriteLine("Это именно то самое  число!");
                }
                else
                {
                    Console.WriteLine("Совсем дурак чтоли, это не оно!");
                }
            }





                      
            
            
            
            
           
        }
    }
}
