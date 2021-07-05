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


        private static bool IsNoneZeroContains(int[] source)
        {
            foreach (var i in source )
            {
                if (i != 0)
                {
                    return true;
                }
            }
            return false;
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

            int value;
            bool x = IsNoneZeroContains(array);
            while(x)
            {
                
                Console.WriteLine("\n  Вспомните любое число: ");
                    bool isNumber = true;

                    isNumber = TryGetValue(out int k);
                    if (isNumber)
                    {
                        var guess = true;
                        while (guess)
                        {                         
                            for (var i = 0; i < array.Length; i++)
                            {
                                if (array[i] == k)
                                {
                                    Console.WriteLine("Вы угадали :)");
                                    array = NewArray(array, k);
                                    guess = false;
                                    break;
                                }                                   
                            }  
                            if (guess == true)
                            {
                                Console.WriteLine("Вы не угдадали");
                                guess = false;
                            }                           
                        }

                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не число!");
                            isNumber = true;
                        }                 
                
                 
                
            }

            Console.WriteLine("Вы угадали все числа!");








        }
   
    }
}
