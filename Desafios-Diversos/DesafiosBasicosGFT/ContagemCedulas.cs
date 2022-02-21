using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.DesafiosBasicosGFT
{
    class ContagemCedulas
    {
        public static void Executar()
        {
            int n, quociente = 0, resto;

            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            for (int i = 0; i < notas.Length; i++)
            {
                quociente = resto / notas[i];
                Console.WriteLine($"{quociente} nota(s) de R$ {notas[i]},00");
                resto = resto % notas[i];
            }
        }
    }
}
