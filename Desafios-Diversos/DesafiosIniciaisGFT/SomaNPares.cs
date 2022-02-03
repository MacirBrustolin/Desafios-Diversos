using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios_Diversos.DesafiosIniciaisGFT {
    class SomaNPares {
        public static void Executar(){
            int x = int.Parse(Console.ReadLine()), varAux, contAux = 0, soma = 0;
            List<int> entradas = new List<int>();
            
            while (x != 0){
              entradas.Add(x);
              x = int.Parse(Console.ReadLine());
            }
            if (entradas.Count() > 0){
              for (int i = 0; i < entradas.Count(); i++){
                varAux = entradas[i];
                while (contAux < 5){
                  if (varAux % 2 == 0){
                    soma += varAux;
                    varAux++;
                    contAux++;
                  }
                  else {
                    varAux++;
                  }
                }
                System.Console.WriteLine(soma);
                soma = 0;
                contAux = 0;
              }
            }
        }
    }
}