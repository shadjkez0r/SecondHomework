using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int result = n % 2;
            if (result == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число нечетное");


            //Задержка
            Console.ReadKey();
               
        }
    }
}
