using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Laba
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double R = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Dlina;
            double dlina = myDelegate(R);
            Console.WriteLine("Длина окружности с радиусом {0} составляет {1}", R, dlina);

            myDelegate = Ploshad;
            double ploshad = myDelegate(R);
            Console.WriteLine("Площадь круга с радиусом {0} составляет {1}", R, ploshad);

            myDelegate = Objem;
            double objem = myDelegate(R);
            Console.WriteLine("Объем шара с радиусом {0} составляет {1}", R, objem);

            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }

        static double Dlina(double r) => Math.PI * 2 * r;

        static double Ploshad(double R) => Math.PI * Math.Pow(R, 2);

        static double Objem(double R) => Math.PI * Math.Pow(R, 3) * 4 / 3;

    }
}
