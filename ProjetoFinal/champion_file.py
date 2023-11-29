class Champion:
    champion_list = []

    def __init__(self, nome, role, hp, ad, ar, mr):
        Champion.champion_list.append(self)
        self.nome = ""
        self.role = role
        self.hp = hp
        self.ad = ad
        self.ar = ar
        self.mr = mr


Champion.nome = Champion("Aatrox", "TOP", "650", "60", "26", "30")
