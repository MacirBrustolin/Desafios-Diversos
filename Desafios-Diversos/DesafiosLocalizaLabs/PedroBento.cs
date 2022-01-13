using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosLocalizaLabs {
    class PedroBento {
        public static void Executar() {
            string joia = "";
            List<string> joiasPossuidas = new List<string>();

            do {
                joia = Console.ReadLine();
                if (joia != null && joia != " ") {
                    joiasPossuidas.Add(joia);
                }
            } while (!string.IsNullOrWhiteSpace(joia));

            IEnumerable<string> joiasDiferentes = joiasPossuidas.Distinct();
            Console.WriteLine(joiasDiferentes.Count());
        }
    }
}
