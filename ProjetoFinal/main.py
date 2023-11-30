import time
import rich
from rich.console import Console
from rich.panel import Panel
from rich.align import Align

"""
This script is used to create a list of presidents and what they did best in their time in power
its also an objective of the task, to search up and insert or delete presidents.
"""
console = Console()
def panel ():
    console.print(Panel("[b][white]US[/b][/white][b][bright_blue] Presidency[/bright_blue][/b]", border_style="red3", height=3, width=50), justify="center")
def menu_panel():
     """
     This function creates a panel with options for users to choose from
     """
     console.print(Panel("[b][bright_blue]//________Menu________//[/bright_blue][/b]", style="white"),justify="center")
def separator():
    """console.print("[bright_blue][b]_______________________________[/bright_blue][/b]", justify="center")"""
def introduzir_dados():
    pass
def sair_programa():
    pass
def ver_lista_presidentes():
    pass
def comparar_presidentes():
    pass
def buscar_presidente():
    pass
def inserir_novo_presidente():
    pass
def ver_partido():
    pass
def eliminar_presidente():
    pass
def alterar_dados():

while True:
    separator()
    menu_panel()
    separator()
    console.print
    user_op = ""
    console.print("[bright_blue][b]1 - [/bright_blue][/b]Visualizar lista de Presidentes", justify="center")
    console.print("[bright_blue][b]2 - [/bright_blue][/b]Introduzir dados na lista", justify="center")
    console.print("[bright_blue][b]3 - [/bright_blue][/b]Comparar presidentes",justify="center")
    console.print("[bright_blue][b]3 - [/bright_blue][/b]Pesquisar por presidente",justify="center")
    console.print("[bright_blue][b]3 - [/bright_blue][/b]Ver por partido",justify="center")
    console.print("[bright_blue][b]4 - [/bright_blue][/b]Eliminar presidente da lista", justify="center")
    console.print("[bright_blue][b]5 - [/bright_blue][/b]Alterar dados de um presidente", justify="center")
    console.print("[bright_blue][b]6 - [/bright_blue][/b]Gerar um presidente.", justify="center")
    console.print("[bright_blue][b]last - [/bright_blue][/b]Sair do programa",justify="center")
    console.print("[]")

    """user_op = int(input("Introduza o número correspondente a ação que pretende."))"""

    match user_op:
        case 1:
            ver_lista_presidentes()
        case 2:
            introduzir_dados()
        case 3:
            comparar_presidentes()
        case 4:
        case _:
            sair_programa()
    break