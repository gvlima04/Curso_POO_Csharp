using System;

namespace _003_Sld39_Classes
{
    public class Triangulo
    {
        public double ladoA; //Public para conseguir acessar os atributos
        public double ladoB;
        public double ladoC;

        public double CalcArea()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));

            return area;
        }

    }
}