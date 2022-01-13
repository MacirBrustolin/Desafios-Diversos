using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios {
    class Vogais {
        public static void Executar() {
            string frase;
            string fraseLower;
            int contaVogais = 0;

            Console.WriteLine("Escreva uma Frase: ");
            frase = Console.ReadLine();
            fraseLower = frase.ToLower();

            for (int i = 0; i < fraseLower.Length; i++) {
                if (fraseLower[i].Equals('a') || fraseLower[i].Equals('e') || fraseLower[i].Equals('i') || 
                    fraseLower[i].Equals('o') || fraseLower[i].Equals('u') || fraseLower[i].Equals('á') ||
                    fraseLower[i].Equals('à') || fraseLower[i].Equals('é') || fraseLower[i].Equals('è') ||
                    fraseLower[i].Equals('â') || fraseLower[i].Equals('ã') || fraseLower[i].Equals('ê') ||
                    fraseLower[i].Equals('ó') || fraseLower[i].Equals('õ') || fraseLower[i].Equals('í')
                    ) {
                    contaVogais++;
                }
            }
            Console.WriteLine("O número de vogais da frase é: {0}", contaVogais);

        }
    }
}