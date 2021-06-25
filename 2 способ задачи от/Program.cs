using System;

namespace _2_способ_задачи_от_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            if (false)
            {
                Console.WriteLine("Вы ввели не число!");
            }          


            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int x5 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Запомните эти числа:{x1},{x2},{x3},{x4},{x5}");

            int[] Num = { x1, x2, x3, x4, x5 };

            Console.WriteLine("Введите одно число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number== Num[0])
            {
                Console.WriteLine("Это именно то самое  число!");
            }
            else if(number==Num[1])
            {
                Console.WriteLine("Это именно то самое  число!");
            }
            else if (number == Num[2])
            {
                Console.WriteLine("Это именно то самое  число!");
            }
            else if (number == Num[3])
            {
                Console.WriteLine("Это именно то самое  число!");
            }
            else if (number == Num[4])
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
