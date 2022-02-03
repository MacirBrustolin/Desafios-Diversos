using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosIniciaisGFT {
    class SquareandCubic {

        public static void Executar() {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
                 Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                
            }
        }
    }
}