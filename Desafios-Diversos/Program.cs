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
            });

            central.SelecionarEExecutar();

        }

    }
}
