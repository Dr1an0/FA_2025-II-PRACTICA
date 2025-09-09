using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera; //declarando variable

            Console.Write("INGRESE SU NOMBRE: ");
            nombre = Console.ReadLine();

            Console.Write("INGRESE SU CARRERA: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, BIENVENIDO AL CURSO DE FUDAMENTOS DE ALGORITMO DE {carrera}");

        }
        static void ejer2()
        {
            Console.WriteLine("\"James\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese numero x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double resu = (double)x / (double)y;

            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + resu);

        }
        static void ejer4()
        {
            Console.Write("Ingrese un número decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("Raiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz3: " + raiz3);
        }
        static void ejer5()
        {
            Console.Write("Ingrese número: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: "+(entero%2));
            Console.WriteLine("División: "+ (deci/3));

        }
        static void ejer6()
        {

        }
    }
}
