using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки ");
            string minTemp24hrs = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру за сутки");
            string maxTemp24hrs = Console.ReadLine();
            float AverageTemp = (Convert.ToSingle(minTemp24hrs) + Convert.ToSingle(maxTemp24hrs)) / 2;
            Console.WriteLine($"Средняя температура за день " + AverageTemp);

            Console.ReadKey();

        }
    }
}