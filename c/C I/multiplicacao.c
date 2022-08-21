#include <stdio.h>

int main() {
	int numero1;
	int numero2;
    int multiplicacao;

	printf("Escreva um numero inteiro: ");
	scanf("%d", &numero1);
	printf("Escreva outro numero inteiro: ");
    scanf("%d", &numero2);
    multiplicacao = numero1 * numero2;
    printf("%d x %d = %d", numero1, numero2, multiplicacao);
}