using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    internal class Program
    {
            delegate double MyDelegate(double r);
            static void Main(string[] args)
            {
                MyDelegate myDelegate1 = Сircumference;
                Console.WriteLine("Введите радиус");
                double d = myDelegate1(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Длина окружности = {0}", d);
                Console.WriteLine("");

                MyDelegate myDelegate2 = СircleArea;
                Console.WriteLine("Введите радиус");
                double s = myDelegate2(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Площадь круга = {0}", s);
                Console.WriteLine("");

                MyDelegate myDelegate3 = VolumeBall;
                Console.WriteLine("Введите радиус");
                double v = myDelegate3(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Объем шара = {0}", v);
                Console.WriteLine("");

                Console.ReadKey();
            }

            static double Сircumference(double r)
            {
                double d = 2 * Math.PI * r;
                Console.WriteLine(d);
                return r;
            }

            static double СircleArea(double r)
            {
                double s = Math.PI * r * r * r;
                Console.WriteLine(s);
                return r;
            }

            static double VolumeBall(double r)
            {
                double v = 4 / 3 * Math.PI * r * r * r;
                Console.WriteLine(r);
                return r;
            }
        }
    }
