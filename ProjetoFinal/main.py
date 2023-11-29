import time
from rich import *
from rich import Console

from champion_file import Champion

"""
class Champion:
    def __init__(self, nome, role, hp, ad, ar, mr):
        self.nome = nome
        self.role = role
        self.hp = hp
        self.ad = ad
        self.ar = ar
        self.mr = mr
"""

console = Console()

console.print("sou gay", style="blue1")


def banner():
    print("+---------------------------------------------+\n"
          "|                                             |\n"
          "|             LEAGUE OF LEGENDS               |\n"
          "|             CHAMPION COMPARER               |\n"
          "|                                             |\n"
          "+---------------------------------------------+\n")


def separator():
    print("_______________________________")


def comparacao_entre_champs():
    pass


def pesquisar():
    champion_instance = Champion("Aatrox", "TOP", 650, 60, 26, 30)
    print(champion_instance)
    exit()


def alterar_dados():
    pass


def introduzir_champion():
    separator()
    print("Introduza os dados conforme lhe for aparecendo no ecrãn: ")
    i = int(input("Quantos Champions pretende inserir no programa."))
    separator()


def gerar_champion():
    pass


def eliminar_champion():
    pass


def export():
    pass


def fechar_programa():
    print("A fechar o comparador")
    time.sleep(0.4)
    exit()


"""
chmp1 = Champion("Aatrox", "60", "", "", "", "")
"""

while True:
    banner()
    separator()
    print("/-----Menu-----/")
    print("1 - Comparação entre Champions")
    print("2 - Pesquisa")
    print("3 - Alteração de dados")
    print("4 - Introdução de um Champion")
    print("5 - Gerar um Champion")
    print("6 - Eliminar Champions")
    print("7 - Exportar Champions")
    print("8 - Fechar programa")

    user_choice = input("Escolha uma opção do menu: ")
    print("")
    match user_choice:
        case "1":
            comparacao_entre_champs()
        case "2":
            pesquisar()
        case "3":
            alterar_dados()
        case "4":
            introduzir_champion()
        case "5":
            gerar_champion()
        case "6":
            eliminar_champion()
        case "7":
            export()
        case "8":
            fechar_programa()
        case _:
            print("Escolha um número presente no menu.\n")
