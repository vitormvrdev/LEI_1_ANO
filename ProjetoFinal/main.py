import time
import rich
import json
from rich.console import Console
from rich.panel import Panel
from rich.align import Align
from presidentes import presidentes
import os


console = Console()

def menu_panel(texto):
     #This function creates a panel with options for users to choose from 
     console.print(Panel(f"[b][bright_blue]" "*10{texto}" "*10[/bright_blue][/b]", style="white", width=30, height=3),justify= "left")
def separator():
    console.print("[bright_blue][b]_______________________________[/bright_blue][/b]", justify= "left")
def introduzir_dados():
    """separator()"""
    console.print(Panel("[b][bright_blue]//________Introdução_de_dados________//[/bright_blue][/b]", style="white"),justify= "left")
    """separator()"""
    nome = input("Nome do Presidente: ")
    ano_inicio = int(input("Ano de Início do Mandato: "))
    ano_fim = int(input("Ano de Fim do Mandato: "))
    partido = input("Partido: ")

    presidente = {
        "nome": nome,
        "ano_inicio": ano_inicio,
        "ano_fim": ano_fim,
        "partido": partido
    }
    presidentes.append(presidente)
    print("Presidente adicionado com sucesso.")
def ver_lista_presidentes():
    os.system('clear')
    console.print("A carregar lista.")
    time.sleep(0.3)
    console.print("A carregar lista..")
    time.sleep(0.5)
    console.print("A carregar lista...\n", highlight= False)
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    for presidente in presidentes:
        print(f"{presidente['nome']}, {presidente['ano_inicio']}, {presidente['ano_fim']}, {presidente['partido']}")
    separator()
    input("ENTER p/ continuar...")

def comparar_presidentes():
    pass
def pesquisar_presidente():
    pass
def ver_partido():
    pass
def eliminar_dados():
    pass
def alterar_dados():
    pass
def gerar_presidente():
    pass
def media_anos_mandato():
    pass
def n_mandatos_partidos():
    pass
def mais_mandatos_ordem():
    pass
def guardar_em_ficheiro(nome_arquivo='presidentes.json'):
    with open(nome_arquivo, 'w') as f:
        json.dump(presidentes, f)
    print(f"Dados guardados em {nome_arquivo}.")
def fechar_programa():
    user_in = input("Tem a certeza que pretende sair?(S/N)").upper()
    if user_in == "S":
        console.print("A fechar[bright_blue][b].[/bright_blue][/b]")
        time.sleep(0.5)
        console.print("A fechar[bright_blue][b]..[/bright_blue][/b]")
        time.sleep(0.5)
        console.print("A fechar[bright_blue][b]...[/bright_blue][/b]")
        time.sleep(1)
        exit()
    else:
        pass


while True:
    #separator()
    menu_panel("Menu")
    #separator()
    console.print("[bright_blue][b]1 - [/bright_blue][/b]Introduzir dados", justify= "left")
    console.print("[bright_blue][b]2 - [/bright_blue][/b]Ver lista atual", justify= "left")
    console.print("[bright_blue][b]3 - [/bright_blue][/b]Comparar presidentes",justify= "left")
    console.print("[bright_blue][b]4 - [/bright_blue][/b]Pesquisar por presidente",justify= "left")
    console.print("[bright_blue][b]5 - [/bright_blue][/b]Ver por partido",justify= "left")
    console.print("[bright_blue][b]6 - [/bright_blue][/b]Eliminar dados da lista", justify= "left")
    console.print("[bright_blue][b]7 - [/bright_blue][/b]Alterar dados de um presidente", justify= "left")
    console.print("[bright_blue][b]8 - [/bright_blue][/b]Gerar um presidente.", justify= "left")
    console.print("[bright_blue][b]9 - [/bright_blue][/b]Calcular a média de anos por mandato.", justify= "left")
    console.print("[bright_blue][b]10 - [/bright_blue][/b]Verificar o número de mandatos por partido.", justify= "left")
    console.print("[bright_blue][b]11 - [/bright_blue][/b]Mostrar os mandatos por ordem.", justify= "left")
    console.print("[bright_blue][b]12 - [/bright_blue][/b]Guardar em ficheiro.", justify= "left")
    console.print("[bright_blue][b]13 - [/bright_blue][/b]Sair do programa",justify= "left")
    menu_choice = input("Escolha o número respetivo à ação que pretende no programa: ")
    print("")
    match menu_choice:
        case "1":
            introduzir_dados()
        case "2":
            ver_lista_presidentes()
        case "3":
            comparar_presidentes()
        case "4":
            pesquisar_presidente()
        case "5":
            ver_partido()
        case "6":
            eliminar_dados()
        case "7":
            alterar_dados()
        case "8":
            gerar_presidente()
        case "9":
            media_anos_mandato()
        case "10":
            n_mandatos_partidos()
        case "11":
            mais_mandatos_ordem()
        case "12":
            guardar_em_ficheiro()
        case "13":
            fechar_programa()
        case _:
            print("Introduza uma opção dentro do fornecido.")
