#include <stdio.h>

int main() {
    int contador = 1;
    int soma = 0;
    while (contador <= 100) {
        soma += contador;
        contador++;
    }
    printf("%d", soma);
}