using System;

namespace Обработка_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float a, b, deg;
               
            try
            {
                Console.WriteLine("Введите значение a");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение b");
                b = Convert.ToInt32(Console.ReadLine());

                deg = (float)Math.Pow(a,b);
                Console.WriteLine("Ответ = " +deg);
            }

            catch
            {
                Console.WriteLine("Возникло исключение!");
            }

            finally
            {
                Console.WriteLine("Блок finally");
            }
        }
    }
}
