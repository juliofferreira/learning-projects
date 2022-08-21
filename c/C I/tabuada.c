#include <stdio.h>

int main() {
    int numero;
    printf("Digite um numero inteiro: ");
    scanf("%d", &numero);
    printf("A tabuada de %d e: \n", numero);
    for(int i = 1; i < 10; i++) {
        int resultadotabuada = numero * i;
        printf("%d x %d = %d\n", numero, i, resultadotabuada);
    }
}