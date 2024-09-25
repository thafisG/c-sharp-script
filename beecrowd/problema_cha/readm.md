# Degustação de Chá às Escuras

Degustação de chá às escuras é a habilidade de identificar um chá usando apenas seus sentidos do olfato e paladar.

Isto faz parte da Competição Ideal de Consumidores de Chá Puro (da sigla em inglês ICPC), que um programa de TV local está organizando. Durante o show, um bule de chá completo é preparado e são entregues uma xícara de chá para cada um dos cinco competidores. Os participantes devem cheirar, saborear e avaliar a amostra, de modo a identificar o tipo de chá, que pode ser: 
1. Chá branco
2. Chá verde
3. Chá preto
4. Chá de ervas

No final, as respostas são verificadas para determinar o número de suposições corretas.

## Entrada

A primeira linha contém um inteiro `T` representando o tipo de chá (1 ≤ T ≤ 4). A segunda linha contém cinco inteiros `A, B, C, D e E`, que indica a resposta dada por cada competidor (1 ≤ A, B, C, D, E ≤ 4).

## Saída

A saída contém um inteiro representando o número de concorrentes que obtiveram a resposta correta.

## Exemplos

| Entrada                  | Saída |
|-------------------------|-------|
| `1`<br>`1 2 3 2 1`      | `2`   |
| `3`<br>`4 1 1 2 1`      | `0`   |
