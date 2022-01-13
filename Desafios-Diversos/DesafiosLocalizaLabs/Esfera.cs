using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosLocalizaLabs {
    class Esfera {
        public static void Executar() {
            double pi, raio, volume;
            pi = 3.14159;

            //escreva o seu código
            Console.WriteLine("Informe o Raio:");
            double.TryParse(Console.ReadLine(), out raio);
            volume = (4.0 / 3.0) * pi * raio * raio * raio;
            Console.WriteLine($"VOLUME = {volume:0.000}");
        }
    }
}
