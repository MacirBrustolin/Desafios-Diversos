using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosLocalizaLabs {
    class HoHoHo {

        public static void Executar() {

            Console.WriteLine("Insira um número inteiro: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                if (i < N - 1) {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                } else {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}

