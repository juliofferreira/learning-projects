#include <stdio.h>

int fibonacci(int number) {
    if(number == 0) return 0;
    if(number == 1) return 1;
    return fibonacci(number - 1) + fibonacci(number - 2);
}

int main() {
    int number = 39;
    int calculatedfibonacci = fibonacci(number);
    printf("O numero de fibonacci para %d e: %d\n", number, calculatedfibonacci);
}