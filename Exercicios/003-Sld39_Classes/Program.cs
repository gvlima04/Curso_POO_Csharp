using System;

namespace _003_Sld39_Classes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ReadLine();
            Triangulo x,y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Informe os lados do triângulo x");
            Console.Write("Lado A: ");
            x.ladoA = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            x.ladoB = double.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            x.ladoC = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe os lados do triângulo y");
            Console.Write("Lado A: ");
            y.ladoA = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            y.ladoB = double.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            y.ladoC = double.Parse(Console.ReadLine());

            double areaX = x.CalcArea();
            double areaY = y.CalcArea();

            Console.WriteLine("A área do triângulo x corresponde a: " + areaX.ToString("F2") + " un.");
            Console.WriteLine("A área do triângulo y corresponde a: " + areaY.ToString("F2") + " un.");

        }
    }
}
