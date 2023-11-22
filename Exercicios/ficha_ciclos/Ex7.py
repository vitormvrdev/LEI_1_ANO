"""
Elabore um programa que dadas as notas de um conjunto de alunos, através de uma
sequência terminada por um n.º negativo, calcule os seguintes valores estatísticos:
▪ nota máxima;
▪ nota mínima;
▪ n.º de positivas (>= 10);
▪ percentagem de negativas;
▪ média das notas;
▪ média das notas positivas.
"""

nota_maxima = float('-inf')
nota_minima = float('inf')
total_notas = 0
total_positivas = 0
total_negativas = 0
soma_notas = 0
soma_notas_positivas = 0

while True:
    nota = float(input("Insira a nota do aluno (ou um número negativo para terminar): "))
    if nota < 0:
        break

    total_notas += 1
    soma_notas += nota
    nota_maxima = max(nota_maxima, nota)
    nota_minima = min(nota_minima, nota)

    if nota >= 10:
        total_positivas += 1
        soma_notas_positivas += nota
    else:
        total_negativas += 1

media_notas = soma_notas / total_notas if total_notas > 0 else 0
media_notas_positivas = soma_notas_positivas / total_positivas if total_positivas > 0 else 0
percentagem_negativas = (total_negativas / total_notas) * 100 if total_notas > 0 else 0

print("\nResultados:")
print(f"Nota Máxima: {nota_maxima}")
print(f"Nota Mínima: {nota_minima}")
print(f"Número de Positivas (>= 10): {total_positivas}")
print(f"Percentagem de Negativas: {percentagem_negativas:.2f}%")
print(f"Média das Notas: {media_notas:.2f}")
print(f"Média das Notas Positivas: {media_notas_positivas:.2f}")

