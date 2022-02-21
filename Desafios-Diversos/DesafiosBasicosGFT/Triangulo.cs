using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosBasicosGFT
{
    class Triangulo
    {
        public static void Executar()
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);


            if ((Math.Abs(a - b) < c || a + b < c) && (Math.Abs(b - c) < a || b + c > a) && (Math.Abs(a - c) < b || c + a > b))
            {
                Console.WriteLine("Perimetro = {0:.0}", (a + b + c));
            }
            else
            {
                Console.WriteLine("Area = {0:.0}", ((a + b) * c) / 2);
            }
        }
    }
}
