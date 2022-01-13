using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosLocalizaLabs {
    class Xenlonguinho {
        public static void Executar() {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++) {
                //escreva o seu código
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine(N - Math.Floor(Math.Sqrt(N)));
            }
        }
    }
}
