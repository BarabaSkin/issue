using System;
using System.Linq;

namespace _2_способ_задачи_от_
{
    class Program
    {
        private static int[] LastValueInArray(int [] values)
        {
         
           var length = values.Length - 1;
           var result = new int[length];
           for (int i = 0; i < length ; i++)
           {
                var item = values[i];
                result[i] = item;
                         
           }
           return result;
        }
        private static int[] FirstValueInArrai(int[] values)
        {
            var length = values.Length -1;
            var result = new int[length];
            for (int i = 1; i < values.Length; i++)
            {
                var item = values[i];
                result[i] = item; 
            }
            return result;
        }




        private static bool TryGetValue(out int val)
        {
            var t = Console.ReadLine();
            bool r = Int32.TryParse(t, out val);            
            return r;
        }


        private static bool IsLengthZero(int[] source)
        {
            if (source.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

       

        private static bool EndOrRepeat()
        {
            Console.WriteLine("\nДля завершения программы напишите'Exit' \nЧтобы начать программу заново напишите 'Repeat'");            
            bool z = true;
            bool r = true;
            while (z)
            {
                var end = Console.ReadLine();               
                if (r = end == "Exit")
                {
                    Console.WriteLine("Завершение программы");
                    z = false;
                    r = false;
                }
                else if(r = end == "Repeat")                
                {
                    Console.WriteLine("Начало программы заново");
                    z = false;
                    r = true;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение! \nПовторите ввод");
                    z = true;
                }               
            }
            return r;           
        }

        
        private static int[] NewArray(int[] source, int value)
        {
            var length = source.Length - 1;
            var result = new int[length];
            var isSkiped = false;
            var iterator = 0;
            foreach (var item in source) 
            {
                if (item == value && !isSkiped)
                {
                    isSkiped = true;

                }
                else 
                {                   
                    result[iterator] = item;
                    iterator++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var random = new Random();
            var ii = random.Next(1, 5);

            bool y = true;
            while (y)
            {
                Console.WriteLine("Введите 5 чисел: ");
                var array = new int[5];
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
             

                bool x = IsLengthZero(array);
                while (!x)
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
                        x = IsLengthZero(array);

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
