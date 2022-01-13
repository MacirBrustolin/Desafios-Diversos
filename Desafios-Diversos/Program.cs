using Desafios_Diversos.Desafios;
using Desafios_Diversos.DesafiosLocalizaLabs;
using System;
using System.Collections.Generic;

namespace Desafios_Diversos {
    class Program {
        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Desafio do Papai Noel", HoHoHo.Executar},
                {"Desafio dividindo X por Y", DividindoXporY.Executar},
                {"Desafio da Esfera", Esfera.Executar},
                {"Desafio do Xenlonguinho", Xenlonguinho.Executar},
                {"Desafio do Pedro Bento e o Mundo de Oz", PedroBento.Executar},

                {"Desafio Altura do Prédio", AlturaPredio.Executar},
                {"Desafio Maior, Menor e Média", MaiorMenorMedia.Executar},
                {"Desafio Números pares e Ímpares", ParesImpares.Executar},
                {"Desafio de Ordenação Decrescente de Array", OrdemArray.Executar},
                {"Desafio Vogais em uma Frase", Vogais.Executar},
            });

            central.SelecionarEExecutar();

        }

    }
}
