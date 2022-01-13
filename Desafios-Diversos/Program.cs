using Desafios_Diversos.Desafios_Localiza_Labs;
using System;
using System.Collections.Generic;

namespace Desafios_Diversos {
    class Program {
        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Desafio do Papai Noel", HoHoHo.Executar},
            });

            central.SelecionarEExecutar();

        }

    }
}
