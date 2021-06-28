using System;

namespace _2_способ_задачи_от_
{
    class Program
    {
        private static bool TryGetValue(out int val)
        {
            var t = Console.ReadLine();     
            bool r = Int32.TryParse(t, out val);  
            return r;
        }
         

        static void Main(string[] args)
        { 

            Console.WriteLine("Введите 5 чисел: ");
            var array =new int[5];


            for (var i = 0; i < array.Length; i++)
            {
                bool isInt = true;
                while (isInt)
                {
                    isInt = TryGetValue(out int t);
                    if (isInt)
                    {
                        array[i] = t;
                        isInt = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число!");
                        isInt = true;
                    }
                }
            }



            Console.WriteLine("Вот все введенные вами числа: ");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Запомните их!");





            Console.WriteLine("Вспомните любое число: ");
            var value = new int[1];
            bool number = true;
            while (number)
            {
                number = TryGetValue(out int k);
                if (number)
                {
                    value[0]=k;
                    number = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                    number = true;
                }
            }
        
            

            foreach (var nums in array)
            {
                if (nums == value[0])
                {
                    Console.WriteLine("Это именно то самое число!");
                }
                else
                {
                    Console.WriteLine("Это вовсе не то число!:");
                }
            }



        }
    }
}
