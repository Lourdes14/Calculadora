using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLS
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            int menu = 0;
            int x1 = 0;
            int x2 = 0;
            int total;

            bool estado = true;

            while (op == 's')
            {
                Console.Clear();
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicacion");
                Console.WriteLine("4.- Division");
                Console.WriteLine("5.- Salir");

                Console.Write("Opción: ");

                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    Console.WriteLine("Suma ");
                    while (estado)
                    {
                        Console.WriteLine("Dato 1: ");
                        try
                        {
                            x1 = int.Parse(Console.ReadLine());
                            estado = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error formato incompleto");
                        }

                    }

                    estado = true;
                    while (estado)
                    {
                        Console.WriteLine("Dato 2:");
                        try
                        {
                            x2 = int.Parse(Console.ReadLine());
                            estado = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error formato incompleto");
                        }
                    }

                    estado = true;
                    Console.Clear();
                    total = x1 + x2;
                    Console.Write("El valor es: " + total);
                }
            }
        }
    }
}
