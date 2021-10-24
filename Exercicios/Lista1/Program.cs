using System;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte menu = 0;
            bool ok;
            while (menu != 9)
            {
                Console.WriteLine("_-_-_MENU_-_-_");
                Console.WriteLine("Digite o número de um dos exercícios propostos");

                Console.WriteLine("2 - Calcula área e perímetro de um círculo");
                Console.WriteLine("4 - Calculo salário funcionário");
                Console.WriteLine("6 - Geometria Plana");
                Console.WriteLine("9 - Sair");

                ok = byte.TryParse(Console.ReadLine(), out menu);
                
                if (ok)
                {
                    switch (menu)
                    {
                        case 2:
                            areaPerimetroCirc();
                            break;
                        case 4:
                            salarioFunc();
                            break;
                        case 6:
                            geometriaPlana();
                            break;
                        default:
                            Console.WriteLine("Selecione um dos valores sugeridos (switch)");
                            break;
                    }
                       
                }
                else
                {
                    Console.WriteLine("Selecione um dos valores sugeridos (else)");
                } 
                    
                 
            }

            Console.WriteLine("Vlw, flw!!");

        }

        static void areaPerimetroCirc()
        {
            Console.Write("Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio, 2);
            double perimetro = 2*Math.PI*raio;

            Console.WriteLine("Uma circuferência com esse raio teria um peímetro igual a " + perimetro.ToString("F4") + " e area de " + area.ToString("F4"));
        }

        static void salarioFunc()
        {
            Console.WriteLine("Código do Funcionário:");
            int codFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas:");
            double horasTrab = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da hora trabalhada");
            double valHoraTrab = double.Parse(Console.ReadLine());

            System.Console.WriteLine("O funcionário de código " + codFunc + " irá receber R$" + (horasTrab*valHoraTrab).ToString("F2") + " pelas " + horasTrab + " horas trabalhadas.");
            
        }

        static void geometriaPlana()
        {
            System.Console.WriteLine("Entre com 3 valores separados por espaço (<a> <b> <c>):");
            string[] s = Console.ReadLine().Split(' ');

            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            System.Console.WriteLine("a) Área do triângulo formado por 'a' (base) e 'c' (altura): " + ((a*c)/2).ToString("F2"));
            System.Console.WriteLine("b) Área da circunferência de raio 'c': " + (Math.PI * Math.Pow(c, 2)).ToString("F2"));
            System.Console.WriteLine("c) Área do trapézio em que 'a' e 'b' são as bases e 'c' a altura: " + ((a+b)*c/2).ToString("F2"));
            System.Console.WriteLine("d) Área do quadrado de lado 'b': " + (Math.Pow(b,2).ToString("F2")));
            System.Console.WriteLine("e) Área do retângulo formado pelos lados 'a' e 'b': " + (a*b).ToString("F2"));
        }
    }
}
