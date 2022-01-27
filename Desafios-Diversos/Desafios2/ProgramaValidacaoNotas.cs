using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios2 {
    class ProgramaValidacaoNotas {

        public static void Executar() {
            double nota1, nota2, media;
            int x=1;
            string nota1s, nota2s;

            do {
                while (true) {

                    nota1s = Console.ReadLine();

                    if (Double.TryParse(nota1s, out double nota1temp) && nota1temp >= 0.0 && nota1temp <= 10.0)
                    {
                        nota1 = nota1temp;
                        break;
                    } else 
                        {
                        Console.WriteLine("nota invalida");
                    } 
                }

                while (true)
                {

                    nota2s = Console.ReadLine();

                    if (Double.TryParse(nota2s, out double nota2temp) && nota2temp >= 0.0 && nota2temp <= 10.0)
                    {
                        nota2 = nota2temp;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }


                media = (nota1 + nota2) / 2;
                Console.WriteLine("media = {0}", media);


                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x == 1);





        }
    }
}