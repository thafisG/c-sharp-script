# Palindrome Number

**Dificuldade:** Fácil  
**Status:** Resolvido  
**Tópicos:** Palíndromos, Números Inteiros, Estruturas de Dados Básicas

## Descrição

Dado um número inteiro `x`, retorne `true` se `x` for um **palíndromo**, e `false` caso contrário.

Um número é considerado um palíndromo quando ele lê o mesmo da esquerda para a direita e da direita para a esquerda. Note que números negativos ou números que não são simétricos não podem ser palíndromos.

---

## Exemplos

### Exemplo 1
- **Entrada:** `x = 121`
- **Saída:** `true`
- **Explicação:** `121` lê-se como `121` tanto da esquerda para a direita quanto da direita para a esquerda.

### Exemplo 2
- **Entrada:** `x = -121`
- **Saída:** `false`
- **Explicação:** Da esquerda para a direita, lê-se `-121`. Da direita para a esquerda, lê-se `121-`. Portanto, não é um palíndromo.

### Exemplo 3
- **Entrada:** `x = 10`
- **Saída:** `false`
- **Explicação:** Da direita para a esquerda, lê-se `01`. Portanto, não é um palíndromo.
