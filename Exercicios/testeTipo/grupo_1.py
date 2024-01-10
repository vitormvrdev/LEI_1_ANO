# a)B

# b)explicação mental

# c)resolução abaixo


conta_negativas = 0
conta_positivas = 0

for i in range(20):
    if i <= 20:
        temp = float(input(f"Introduza a temperatura {i+1}: "))
        if temp < 0:
            conta_negativas += 1
        else:
            conta_positivas += 1
    i += 1
else:
    print(f"Temperaturas positivas: {conta_positivas}")
    print(f"Temperaturas negativas: {conta_negativas}")