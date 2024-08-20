"""
Uma sociedade de beneficência fez o seu peditório anual, que rendeu 25000 €., sendo
distribuídos por 100 famílias mais necessitadas da cidade, de acordo com o seguinte critério:
▪ Cada família recebe 150€. de base mais uma parcela igual a 10% do valor de base por
cada filho até 3 anos e 15% por cada filho com idade superior a 3 anos.
Elabore um programa que leia para cada família o número de filhos e respectivas idades e
indique quanto vai receber cada família, qual foi a média de donativos por família e se o
peditório foi suficiente para cobrir o total das despesas.
"""

def calcular_donativo(numero_filhos, idades_filhos):
    base = 150
    percentagem_ate_3_anos = 0.10
    percentagem_superior_3_anos = 0.15

    total_donativo = base

    for idade in idades_filhos:
        if idade <= 3:
            total_donativo += base * percentagem_ate_3_anos
        else:
            total_donativo += base * percentagem_superior_3_anos

    return total_donativo

def main():
    total_donativos = 25000
    numero_familias = 2

    total_recebido = 0

    for i in range(numero_familias):
        print(f"\nFamília {i + 1}:")
        numero_filhos = int(input("Número de filhos: "))
        idades_filhos = [int(input(f"Idade do filho {j + 1}: ")) for j in range(numero_filhos)]

        donativo_familia = calcular_donativo(numero_filhos, idades_filhos)
        total_recebido += donativo_familia

        print(f"Valor a receber pela família: {donativo_familia} €")

    media_donativos = total_recebido / numero_familias

    print("\nResultados:")
    print(f"Média de donativos por família: {media_donativos} €")

    if total_recebido <= total_donativos:
        print("O peditório foi suficiente para cobrir o total das despesas.")
    else:
        print("O peditório não foi suficiente para cobrir o total das despesas.")

if __name__ == "__main__":
    main()
