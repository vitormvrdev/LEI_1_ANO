# a)B

# b)explicação mental

# c)resolução abaixo


i = 1
conta_negativas = 0
conta_positivas = 0

for i in range(20):
    if i <= 20:
        print("Temperatura", i ,":")
        temp = int(input("Introduza a temperatura."))
        if temp < 0:
            conta_negativas += 1
        else:
            conta_positivas += 1
    i += 1
else:
    print(f"Temperaturas positivas: {conta_positivas}")
    print(f"Temperaturas negativas: {conta_negativas}")

