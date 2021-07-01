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




        private static bool EndOrRepeat()
        {
            Console.WriteLine("Для завершения программы напишите'Exit' \nЧТобы начать программу заново напишите 'Repeat'");
            var end = Console.ReadLine();
            bool r = end == "Exit";          
            if (r)
            {
                Console.WriteLine("End");
                r = false;
            }           
            r = end == "Repeat";
            if (r)
            {               
                Console.WriteLine("Repeat");
                r = true;
            }
            return r;
        }




        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                Console.WriteLine("Введите 5 чисел, отличных от 0: ");
                var array = new int[5];


                for (var i = 0; i < array.Length; i++)
                {
                    bool isInt = true;
                    while (isInt)
                    {
                        isInt = TryGetValue(out int t);
                        if (t == 0)
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
                while (x)
                {

                    Console.WriteLine("\n  Вспомните любое число: ");
                    bool isNumber = true;

                    isNumber = TryGetValue(out int k);
                    if (isNumber)
                    {
                        for (var i = 0; i < array.Length; i++)
                        {
                            if (array[i] == k)
                            {
                                Console.WriteLine("Это именно то самое число!");
                                array[i] = 0;
                            }
                        }
                        x = IsNoneZeroContains(array);

                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число!");
                        isNumber = true;
                    }

                }
                Console.WriteLine("Вы угадали все числа!");

                y = EndOrRepeat();

            }






            








        }
   
    }
}
