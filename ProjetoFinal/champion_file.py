champion_list = []
class Champion:
    def __init__(self, nome, role, hp, ad, ar, mr):
        self.nome = nome
        self.role = role
        self.hp = hp
        self.ad = ad
        self.ar = ar
        self.mr = mr

# Create an instance of the Champion class
aatrox = Champion("Aatrox", "TOP", 650, 60, 26, 30)

# Append the instance to the champion_list
champion_list.append(aatrox)

# Print the champion_list
print(champion_list)
