import random

heads = 1
tails = 0 
random_choice = random.randint(0,1)

if random_choice == heads:
    print("Cabeçorra!")
else:
    print("Caudas!")