#include <stdio.h>

int soma(int* num, int a, int b) {
    *num = a + b;
}

int main() {
    int num;
    int a = 3;
    int b = 5;
    soma(&num, a, b);
    printf("%d", num);
}