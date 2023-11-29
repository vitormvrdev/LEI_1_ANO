import time
from rich import table

class Champion:
    def __init__(self, nome, role, hp, ad, ar, mr):
        self.nome = nome
        self.role = role
        self.hp = hp
        self.ad = ad
        self.ar = ar
        self.mr = mr

def separator():
    print("------------------------")
def comparacao_entre_champs():

def pesquisar():

def alterar_dados():


def introduzir_champion():
    separator()
    print("Introduza os dados conforme lhe for aparecendo no ecrãn: ")

    separator()

def gerar_champion():

def eliminar_champion():


def export():


"""
chmp1 = Champion("Aatrox", "60", "", "", "", "")
"""
while True:
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
            exit()
        case _:
            print("Escolha um número presente no menu.\n")
