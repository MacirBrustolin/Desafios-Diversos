using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios {
    class OrdemArray {
        public static void Executar() {
            double[] numeros = new double[5];
            double guardanumero;

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine("Informe o {0} número:", i + 1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length - 1; i++) {
                for (int j = 0; j < numeros.Length - 1; j++) {
                    if (numeros[j] < numeros[j + 1]) {
                        guardanumero = numeros[j + 1];
                        numeros[j + 1] = numeros[j];
                        numeros[j] = guardanumero;
                    }
                }
            }
            Console.Write("\nOrdem decrescente: ");
            for (int i = 0; i < numeros.Length; i++) {
                Console.Write(numeros[i]);
                Console.Write(" ");
            }

        }
    }
}
