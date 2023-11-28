import random

def sorteio_rifas():
    # Defina as séries disponíveis
    series = ['A', 'B', 'C', 'D']

    # Dicionário para armazenar os números sorteados para cada série
    numeros_sorteados = {}

    # Gere um número aleatório para cada série
    for serie in series:
        numero_sorteado = random.randint(1, 500)
        numeros_sorteados[serie] = numero_sorteado

    # Exiba os resultados
    for serie, numero in numeros_sorteados.items():
        print(f"Série {serie} - Número sorteado: {numero}")

# Chame a função para realizar o sorteio
sorteio_rifas()