using System;
using System.Linq;

namespace _2_способ_задачи_от_
{
   
    class Program
    {
        private static bool TryGetValue(out int val)
        {
            var String = Console.ReadLine();
            bool isInt = Int32.TryParse(String, out val);
            return isInt;
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
                else if (r = end == "Repeat")
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

            bool endOrNot = true;
            while (endOrNot)
            {

                var random = new Random();
                int[] array = new int[3];
                for (var C = 0; C < 3; C++)
                {
                    var ii = random.Next(1, 5);
                    array[C] = ii;
                }

                Console.WriteLine("Дано 3 числа от 1 до 5. Числа могут повторяться! \nУгадайте их!");
                bool lengthZero = IsLengthZero(array);
                while (!lengthZero)
                {
                    Console.WriteLine("\n Введите предполагаемое число: ");
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
                                Console.WriteLine("Вы не угадали");
                                guess = false;
                            }
                        }

                        lengthZero = IsLengthZero(array);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число!");
                        isNumber = true;
                    }

                }
                Console.WriteLine("Вы угадали все числа!");
                endOrNot = EndOrRepeat();
            }
        }

    }   
}
