using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios {
    class ParesImpares {
        public static void Executar() {
            int[] numeros = new int[] { 1, 3, 35, 40, 85, 123, 121, 209, 200, 305, 350 };
            var pares = new List<int>();
            var impares = new List<int>();

            for (int i = 0; i < numeros.Length; i++) {
                if (numeros[i] % 2 == 0) {
                    pares.Add(numeros[i]);
                } else {
                    impares.Add(numeros[i]);
                }
            }
            Console.Write("Numeros Pares: ");
            for (int i = 0; i < pares.Count; i++) {
                Console.Write("{0} ", pares[i]);
            }
            Console.Write("\nNumeros Impares: ");
            for (int i = 0; i < impares.Count; i++) {
                Console.Write("{0} ", impares[i]);
            }
        }
    }
}
