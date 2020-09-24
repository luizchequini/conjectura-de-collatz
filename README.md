# conjectura-de-collatz

Conjectura de Collatz ou Problema 3x + 1

Desenvolvi um algoritmo com Windows Console Application somente para treinar, e neste desenvolvimento resolvi passar o que aprendi no desenvolvimento do E-Commerce DDD - Domain Driven Dezign, para esta pequena aplicação, observando que não apliquei o DDD por completo mas sim separar às responsabilidades entre Service e o Repository.

Dentro do Interface de Service realizei todos os processos de cálculos e designando os serviço a esta responsabilidade.

E sucessivamente deixei a Interface de Repository responsável em realizar pesquisas e retornar valores.

O desafio proposto foi fazer o sistema descobrir qual o número inicial entre 1 e 1 milhão que produz a maior sequência.

E o resultado entre 1 a 1.000.000 é o número 910.107 com o total de 476 sequências.

E este problema funciona basicamente assim:

Pegue qualquer número inteiro positivo e realize os seguintes procedimentos de cálculos.
Se o número é par, divida-o por 2 ( x / 2 )
Se é ímpar, multiplique-o por 3 e some 1 (3x + 1)

Exemplo, vamos pegar o número 13:
3 * 13 + 1 = 40
40 / 2 = 20
20 / 2 = 10
10 / 2 = 5
3 * 5 + 1 = 16
16 / 2 = 8
8 / 2 = 4
4 / 2 = 2
2 / 1 = 1
Iniciando de 13 e terminando em 1 temos 10 termos.

