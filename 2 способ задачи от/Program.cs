using System;
using System.Linq;

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

            Console.WriteLine("Введите 5 чисел, отличных от 0: ");
            var array = new int[5];


            for (var i = 0; i < array.Length; i++)
            {
                bool isInt = true;
                while (isInt)
                {
                    isInt = TryGetValue(out int t);
                    if(t==0)
                    {
                        Console.WriteLine("Вы ввели не правильное значение!");
                        isInt = true;
                    }
                    else if (isInt)
                    {
                        array[i] = t;
                        isInt = false;
                    }                 
                    else if (!isInt)
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







            var value = new int[1];
            bool x = true;
            while(x)
            {
            Console.WriteLine("\nВспомните любое число: ");
                bool number = true;
                while (number)
                {
                    number = TryGetValue(out int k);
                    if (number)
                    {
                        value[0] = k;
                        number = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число!");
                        number = true;
                    }
                }

                foreach(var nums in array)
                {
                    if (nums == value[0])
                    {
                        Console.WriteLine("Это именно то самое число!");
                        array = array.Where(val => val != nums).ToArray();
                        x = false;
                    }
                    else
                    {
                        Console.WriteLine("Это вовсе не то число!");
                        x = true;
                    }
                }

            }










        }
   
    }
}
