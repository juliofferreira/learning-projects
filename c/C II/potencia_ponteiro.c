#include <stdio.h>

void potencia(int* resultado, int a, int b) {
    if (b == 0) {
        printf("%d", 1);
    } else {
        int resultado = 1;
        for (int i = 0; i < b; i++) {
            resultado *= a;
        }
        printf("%d", resultado);
    }
}

int main() {
    int resultado;
    potencia(&resultado, 3, 3);
}