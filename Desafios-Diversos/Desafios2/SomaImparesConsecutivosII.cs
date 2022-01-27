using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios2 {
    class SomaImparesConseutivosII {

        public static void Executar() {

            int soma, casos, x, y, z;

            while (true)
            {
                Console.Write("N = ");
                if (Int32.TryParse(Console.ReadLine(), out int casosCheck) && casosCheck > 0)
                {
                    casos = casosCheck;
                    break;
                } else
                {
                    Console.WriteLine("Insira um valor válido para o numero de casos (inteiro e maior ue zero).");
                }
            }


            for (int i = 0; i < casos; i++) {
                soma = 0;

                while (true)
                {
                    Console.Write("X = ");
                    if (Int32.TryParse(Console.ReadLine(), out int xCheck))
                    {
                        x = xCheck;
                        break;
                    }
                }

                while (true)
                {
                    Console.Write("Y = ");
                    if (Int32.TryParse(Console.ReadLine(), out int yCheck))
                    {
                        y = yCheck;
                        break;
                    }
                }

                if (y < x)
                {
                    z = x;
                    x = y;
                    y = z;
                }

                for (int j = x + 1; j < y; j++)
                {
                    if ( j % 2 == 1)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine("soma = {0}", soma);

            }
        }
    }
}
