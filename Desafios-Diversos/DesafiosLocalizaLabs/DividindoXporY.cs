using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosLocalizaLabs {
    class DividindoXporY {

        public static void Executar() {

            int limit = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++) {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y != 0) {
                    double Z = X / Y;
                    Console.WriteLine("{0:0.0}", Z);
                } else {
                    Console.WriteLine("divisao impossivel");
                }

            }
        }
    }
}