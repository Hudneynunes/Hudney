/*
 * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159
 */
using System;
using System.Globalization;

namespace Exerciciosecao3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0, raio, pi = 3.14159;
            Console.WriteLine("Didite o valor do raio (r) ");
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Area = " + area.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
    }

