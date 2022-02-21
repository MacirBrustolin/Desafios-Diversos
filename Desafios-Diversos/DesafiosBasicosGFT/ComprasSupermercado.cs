using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafios_Diversos.DesafiosBasicosGFT
{
    class ComprasSupermercado
    {
        public static void Executar()
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            List<List<string>> lista = new List<List<string>>();
            List<string> row = new List<string>();

            // Implemente a solução aqui
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                string[] itens = Console.ReadLine().Split(' ');
                foreach (var item in itens)
                {
                    row.Add(item);
                }
                lista.Add(row);
                row = new List<string>();
            }
            for (int i = 0; i < lista.Count; i++)
            {
                List<string> tmp = new List<string>(lista[i]);
                tmp.Sort();
                for (int j = 0; j < tmp.Count; j++)
                {
                    lista[i][j] = tmp[j];
                }

                foreach (var l in lista[i].Distinct())
                {
                    Console.Write("{0} ", l);
                }
                Console.WriteLine();
            }
            
        }
    }
}
