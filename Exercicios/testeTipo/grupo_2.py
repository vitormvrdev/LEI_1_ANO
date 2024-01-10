lista_nums = []
"""COMPLICOMETRO    max_value = lista_nums[0]
                    min_value = lista_nums[0]

                    def maximum_value():
                        for num in lista_nums():
                            if num > max_value:
                  

                    def minimum_value():
                        pass
"""
max_value = 0
min_value = 99999

soma = 0
media = 0
j = int(input("Introduza o n de numeros!"))
for i in range(j):
    temp = float(input(f"Introduza a temperatura{i}: "))
    lista_nums.append(temp)
    soma += temp 
    if temp > max_value:
        max_value = temp    
    if temp < min_value:
        min_value = temp
    media = soma/j

print(media)
print(max_value) 
print(min_value) 