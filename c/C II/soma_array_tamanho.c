#include <stdio.h>

int soma(int* array, int tamanhoarray) {
    int resultado = 0;
    for(int i = 0; i < tamanhoarray; i++) {
        resultado += array[i];
    }
    return resultado;
}

int main() {
    int nums[3];
    nums[0] = 10;
    nums[1] = 20;
    nums[2] = 30;
    int somaarray = soma(nums, 3);
    printf("%d", somaarray);
}