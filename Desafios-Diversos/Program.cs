using Desafios_Diversos.Desafios;
using Desafios_Diversos.Desafios2;
using Desafios_Diversos.DesafiosLocalizaLabs;
using Desafios_Diversos.DesafiosIniciaisGFT;
using System;
using System.Collections.Generic;
using Desafios_Diversos.DesafiosBasicosGFT;

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

                {"Desafio Soma de Ímpares Consecutivos II", SomaImparesConseutivosII.Executar},
                {"Desafio Soma de Ímpares Consecutivos III", SomaImparesConseutivosIII.Executar},
                {"Desafio Programa para Validação de Notas", ProgramaValidacaoNotas.Executar},

                {"Desafio Escrever o nome do mês em inglês a partir de um numero inteiro N (1 < N < 12)", MonthByNumber.Executar},
                {"Desafio Quadrado e Cubo", SquareandCubic.Executar},
                {"Desafio Somar proxímos N números onde N é informado pelo usuário", SomaNPares.Executar},

                {"Desafio Total de Cédulas", ContagemCedulas.Executar},
                {"Desafio Triângulo", Triangulo.Executar},
                {"Desafio Compras no Supermercado", ComprasSupermercado.Executar},
            });

            central.SelecionarEExecutar();
            

        }

    }
}
