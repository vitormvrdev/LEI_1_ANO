import time
import rich
import json
from rich.console import Console
from rich.panel import Panel
from rich.align import Align
from presidentes import presidentes
import os
from operator import itemgetter


console = Console()
def error_message():
    console.print("[bright_red][b]!!!ERRO!!![/bright_red][/b]")
def delay():
    time.sleep(0.5)
def clear_console():
    os.system('cls')
def menu_panel(texto):
     #This function creates a panel with options for users to choose from 
    #console.print(Panel(f"[b][bright_blue]{texto}[/bright_blue][/b]", style="white", width=30, height=3),justify= "center")
    console.print("="*20)
    console.print(f"{texto:^20}")
    console.print("-"*20)
def separator():
    console.print("[bright_blue][b]--------------------[/bright_blue][/b]")
def introduzir_dados():
    separator()
    menu_panel("Introdução de Dados")
    separator()
    while True:
        try:
            n = int(input("Quantos dados vai querer introduzir? \n"))
            if n >= 0:
                break
            else:
                error_message()
                print("O número de presidentes a introduzir tem que ser maior que 0.")
                error_message
                time.sleep(0.5)
        except ValueError:
            error_message()
            print("Tem que introduzir um número.\nLetras não estão incluidas.")
            delay()
    if n > 0:
        for i in range(n):
            nome = input(f"Nome do Presidente {i + 1}: ")
            while True:
                try:
                    ano_inicio = int(input("Ano de Início do Mandato: "))
                    if ano_inicio <= 1789:
                        console.print("A Revolução Americana aconteceu no ano de [bright_red][b]1789[/bright_red][/b]\npor isso, o número introduzido tem de ser maior que [bright_red][b]1789[/bright_red][/b].")
                        error_message()
                        delay()
                    elif ano_inicio >= 1789:
                        ano_fim = int(input("Ano de Fim do Mandato: "))
                        break
                    elif ano_inicio > ano_fim:
                        print("O ano de fim, tem de ser maior que o ano inicial.")
                        error_message()
                        delay()
                    time.sleep(1)
                except ValueError:
                    console.print("[bright_red][b]Os Valores introduzidos estão errados![/bright_red][/b]", justify="left")
            partido = input("Partido: ")
        presidente = {
            "nome": nome,
            "ano_inicio": ano_inicio,
            "ano_fim": ano_fim,
            "partido": partido
            }
        presidentes.append(presidente)
        print("Presidente adicionado com sucesso.")
        time.sleep(1)
        i += 1
        clear_console()
def ver_lista_presidentes():
    clear_console()
    console.print("A carregar lista.")
    time.sleep(0.3)
    console.print("A carregar lista..")
    time.sleep(0.5)
    console.print("A carregar lista...\n", highlight= False)
    separator()
    menu_panel("Presidentes")
    time.sleep(1)

    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()
    else:
        for i, presidente in enumerate(presidentes, start= 1):
            print(f"{i}- {presidente['nome']}, {presidente['ano_inicio']}, {presidente['ano_fim']}, {presidente['partido']}")
    separator()
def pesquisar_presidente():
    """
    por que dado pretende pesquisar
        match case
            seleção
                fim
    """
    clear_console()
    console.print("A carregar lista.")
    time.sleep(0.3)
    console.print("A carregar lista..")
    time.sleep(0.5)
    console.print("A carregar lista...\n", highlight= False)
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()
    
    pass
def comparar_presidentes():
    clear_console()
    console.print("A carregar lista.")
    time.sleep(0.3)
    console.print("A carregar lista..")
    time.sleep(0.5)
    console.print("A carregar lista...\n", highlight= False)
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()
    pass
def ver_partido():
    """
    por que partido pretende pesquisar?
        mostrar todos os presidentes desse partido
    
    clear_console()
    console.print("A carregar lista.")
    time.sleep(0.3)
    console.print("A carregar lista..")
    time.sleep(0.5)
    console.print("A carregar lista...\n", highlight= False)
    separator()
    menu_panel("Presidentes")
    time.sleep(1)

    if len(presidentes) == 0:
        print("A lista está vazia, introduza valores na lista.")
        time.sleep(2.5)
        separator()
        return
    

    partido_user = input("Por que partido pretende pesquisar? ").lower()

    for presidente in presidentes:
        if partido_user == presidentes[presidente["partido"]]:
            newlist = sorted(presidentes, key=itemgetter('partido'))
            print(newlist)
    """
    user_partido = presidentes(partido="Federalista")
    itemgetter("partido")(user_partido)
    print(itemgetter)

def eliminar_dados():
    ver_lista_presidentes()
    if len(presidentes) == 0:
        print("A lista está vazia introduza dados primeiro.")
        time.sleep(2.5)
        separator()

    elif len(presidentes) != 0:
        num = int(input("Que entrada pretende que seja removida da lista?  "))

        if 0 < num < len(presidentes):
            presidentes.pop(num - 1)
            print("Entrada removida com exito.")
            time.sleep(2)
            input("\nENTER p/ continuar...")    
        elif num > len(presidentes):
            print(f"Número fora do número de entradas, introduza um número entre 1 e {len(presidentes)}")  
def alterar_dados():
    """
    mostrar todos os dados do momento no programa
        w3schools
            perguntar qual entrada de dados quer alterar
                alterar essa entrada de dados
    """
    ver_lista_presidentes()
    pass
def gerar_presidente():
    """
    o programa vai ao ficheiro presidentes.py
        randomiza uma das listas e adiciona a lista principal de presidentes
            ver_lista_presidentes()
    """
    pass
def media_anos_mandato():
    """
    calcular a média de todos os mandatos na lista
        animação de "A calcular"
    """
    pass
def n_mandatos_partidos():
    """EXTRAAAAA!!!
    calcular o n de mandatos de cada partido
        print dos resultados de maior para menor com gráfico

        FALAR COM O MANUEL DATA SCIENCE
    """
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
    elif user_in == "N":
        return
    else:
        print("Input inválido, por favor 'S' para sim e 'N' para não.")


while True:
    separator()
    menu_panel("Menu")
    separator()
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
    console.print("[bright_blue][b]11 - [/bright_blue][/b]Guardar em ficheiro.", justify= "left")
    console.print("[bright_blue][b]12 - [/bright_blue][/b]Sair do programa",justify= "left")
    menu_choice = input("Escolha o número respetivo à ação que pretende no programa: ")
    print("")
    match menu_choice:
        case "1":
            clear_console()
            introduzir_dados()
        case "2":
            ver_lista_presidentes()
            input("ENTER p/ continuar...")
            clear_console()
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
            guardar_em_ficheiro()
        case "12":
            fechar_programa()
        case _:
            print("Por favor, introduza uma opção dentro de 1 a 12.")