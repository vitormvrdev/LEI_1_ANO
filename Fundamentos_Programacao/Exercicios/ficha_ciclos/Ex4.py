"""
    Escreva um programa que leia uma sequência de números inteiros terminada em zero e
    calcule:
    ▪ máximo,
    ▪ mínimo,
    ▪ a soma dos números introduzidos,
    ▪ total dos números pares e ímpares introduzidos
"""

def main():
    numero = int(input("Digite um número (0 para parar): "))
    
    if numero == 0:
        print("Nenhum número foi inserido.")
        return
    
    soma = numero
    maximo = numero
    minimo = numero
    total_pares = 0
    total_impares = 0

    while numero != 0:
        soma += numero
        if numero > maximo:
            maximo = numero
        if numero < minimo:
            minimo = numero
        if numero % 2 == 0:
            total_pares += numero
        else:
            total_impares += numero

        numero = int(input("Digite um número (0 para parar): "))

    print("Máximo:", maximo)
    print("Mínimo:", minimo)
    print("Soma:", soma)
    print("Total de números pares:", total_pares)
    print("Total de números ímpares:", total_impares)

if __name__ == "__main__":
    main()
