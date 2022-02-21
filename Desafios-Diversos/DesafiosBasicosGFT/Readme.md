# :question: Contagem Cédulas
Faça a leitura de um valor inteiro. Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto. As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. Na sequência mostre o valor lido e a relação de notas necessárias.

## Entrada
Você receberá um valor inteiro N (0 < N < 1000000).

## Saída
Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo. Após cada linha deve ser imprimido o fim de linha.

Exemplo de Entrada	Exemplo de Saída
576                 576
                    5 nota(s) de R$ 100,00
                    1 nota(s) de R$ 50,00
                    1 nota(s) de R$ 20,00
                    0 nota(s) de R$ 10,00
                    1 nota(s) de R$ 5,00
                    0 nota(s) de R$ 2,00
                    1 nota(s) de R$ 1,00

11257	            11257
                    112 nota(s) de R$ 100,00
                    1 nota(s) de R$ 50,00
                    0 nota(s) de R$ 20,00
                    0 nota(s) de R$ 10,00
                    1 nota(s) de R$ 5,00
                    1 nota(s) de R$ 2,00
                    0 nota(s) de R$ 1,00

503	                503
                    5 nota(s) de R$ 100,00
                    0 nota(s) de R$ 50,00
                    0 nota(s) de R$ 20,00
                    0 nota(s) de R$ 10,00
                    0 nota(s) de R$ 5,00
                    1 nota(s) de R$ 2,00
                    1 nota(s) de R$ 1,00

<br><br>

# :question: Triângulo
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo (soma de todos os lados) e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem:

Area = XX.X

Fórmula da área de um trapézio: AREA = ((A + B) x C) / 2

## Entrada
A entrada contém três valores reais.

## Saída
O resultado deve ser apresentado com uma casa decimal.

Exemplo de Entrada	Exemplo de Saída
6.0 4.0 2.0         Area = 10.0

6.0 4.0 2.1         Perimetro = 12.1

<br><br>

# :question: Compras no Supermercado
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.
## Entrada
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.
## Saída
A saída contém N linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética.


Exemplo de Entrada	                            Exemplo de Saída
2
carne laranja suco picles laranja picles        carne laranja picles suco
laranja pera laranja pera pera                  laranja pera



<br><br>

