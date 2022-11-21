using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            Console.WriteLine("Градусы:");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минуты:");
            int min_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Секунды:");
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Radians radians = new Radians(gradus_, min_, sec_);

            float totalRadians = radians.ToRadians();
            Console.WriteLine("Радианы = {0:f4}", totalRadians);
            Console.ReadKey();
        }

    }
}

