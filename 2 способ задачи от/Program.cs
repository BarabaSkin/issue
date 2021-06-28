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


















           
        }
    }
}
