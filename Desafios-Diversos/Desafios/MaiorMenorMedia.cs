using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafios_Diversos.Desafios {
    class MaiorMenorMedia {
        public static void Executar() {
            double[] numeros = new double[3];

            for (int i = 0; i <= numeros.Length; i++) {
                Console.WriteLine("Informe o {0} número:", i+1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("O menor valor do vetor é: {0}", numeros.Min());
            Console.WriteLine("O maior valor do vetor é: {0}", numeros.Max());
            Console.WriteLine("O valor médio do vetor é: {0}", numeros.Average());

        }
    }
}
