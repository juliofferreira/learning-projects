#include <stdio.h>

void soma(int numeros[10]) {
    int soma = 0;
    for(int i = 0; i < 10; i++) {
        soma += numeros[i];
    }
    printf("%d", soma);
}

int main() {
    int numeros[10];
    numeros[0] = 10;
    numeros[1] = 20;
    soma(numeros);
}