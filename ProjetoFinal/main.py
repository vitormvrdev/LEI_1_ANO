import time
import rich
import json
from rich.console import Console
from rich.panel import Panel
from rich.align import Align
import os
from presidentes import *
import random


console = Console()
def loading_animation(texto):
    console.print(f"[bright_blue][b]{texto}.[/bright_blue][/b]")
    time.sleep(0.3)
    console.print(f"[bright_red][b]{texto}..[/bright_red][/b]")
    time.sleep(0.5)
    console.print(f"[b]{texto}...\n[/b]", highlight= False)
    time.sleep(1)

def error_message():
    console.print("[bright_red][b]!!!ERRO!!![/bright_red][/b]")
def clear_console():
    os.system('cls')
def menu_panel(texto):
    #This function creates a panel with options for users to choose from.
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
                time.sleep(0.5)
        except ValueError:
            error_message()
            print("Tem que introduzir um número.\nLetras não estão incluidas.")
    if n > 0:
        for i in range(n):
            print("ENTER p/sair: ")
            while True:
                nome = input(f"Nome do Presidente {i + 1}: ")
                if nome == "":
                    return
                try:
                    ano_inicio = int(input("Ano de Início do Mandato: "))
                    if ano_inicio <= 1789:
                        error_message()
                        console.print("A Revolução Americana aconteceu no ano de [bright_red][b]1789[/bright_red][/b]\npor isso, o número introduzido tem de ser maior que [bright_red][b]1789[/bright_red][/b].")
                        
                    elif ano_inicio >= 1789:
                        ano_fim = int(input("Ano de Fim do Mandato: "))
                        break
                    elif ano_inicio > ano_fim:
                        error_message()
                        print("O ano de fim, tem de ser maior que o ano inicial.")
                        
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
        print("ENTER p/continuar...")
        clear_console()
def ver_lista_presidentes():
    clear_console()
    menu_panel("Presidentes")
    loading_animation("A carregar")

    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()
    else:
        for i, presidente in enumerate(presidentes, start=1):
            print(f"{i} - {presidente['nome']}, {presidente['ano_inicio']}, {presidente['ano_fim']}, {presidente['partido']}")
def pesquisar_presidente():
    loading_animation("A pesquisar")
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()

    while True:
        nome_presidente = input("Introduza o nome pelo qual pretende procurar('s'para sair): ")
        encontrou = False
        if nome_presidente == "s":
            break
        else:
            for presidente in presidentes:
                if presidente["nome"].lower().find(nome_presidente.lower()) != -1:
                    print(f"Nome: {presidente["nome"]} ano inicio: {presidente["ano_inicio"]}, ano fim: {presidente["ano_fim"]}, partido: {presidente["partido"]}")
                    encontrou = True 
            if encontrou == False:
                print("Não existe presidente com esse nome na Lista!") 
def comparar_presidentes():
    ver_lista_presidentes()

    if len(presidentes) == 0:
        return  # Se a lista estiver vazia, não há nada para comparar

    elif len(presidentes) != 0:
        num1 = int(input("Diga o 1º presidente para comparação: "))
        num2 = int(input("Diga o 2º presidente para comparação: "))

        if 0 < num1 <= len(presidentes) and 0 < num2 <= len(presidentes):
            presidente1 = presidentes[num1 - 1]
            presidente2 = presidentes[num2 - 1]

            loading_animation("Comparando Presidentes")
            menu_panel("Comparador")
            print(f"1º Presidente: {presidente1['nome']}, {presidente1['ano_inicio']}, {presidente1['ano_fim']}, {presidente1['partido']}")
            print(f"2º Presidente: {presidente2['nome']}, {presidente2['ano_inicio']}, {presidente2['ano_fim']}, {presidente2['partido']}")
            console.input("Enter p/continuar...")
        else:
            console.print("[bright_red][b]Números inválidos. Certifique-se de selecionar números dentro da faixa válida.[/bright_red][/b]")      
def ver_partido():
    """
    por que partido pretende pesquisar?
        mostrar todos os presidentes desse partido
    """
    loading_animation("A carregar")
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    """
    if len(presidentes) == 0:
        print("A lista está vazia, introduza valores na lista.")
        time.sleep(2.5)
        separator()
        return
    """
    partido_user = input("Por que partido pretende pesquisar? ")

    for presidente in presidentes:
        if partido_user == presidente["partido"]:
            print(f"Nome {presidente['nome']}, {presidente['ano_inicio']}, {presidente['ano_fim']}, {presidente['partido']}")

    input("Enter p/continuar...")           
def eliminar_dados():
    ver_lista_presidentes()

    if len(presidentes) == 0:
        print("A lista está vazia introduza dados primeiro.")
        time.sleep(2.5)
        separator()

    elif len(presidentes) != 0:
        num = int(input("Que entrada pretende que seja removida da lista?  "))

        if 0 < num <= len(presidentes):
            presidentes.pop(num - 1)           
            print("Entrada removida com exito.")
            time.sleep(2)
            input("\nENTER p/ continuar...")    
        elif num > len(presidentes):
            print(f"Número fora do número de entradas, introduza um número entre 1 e {len(presidentes)}")  
def alterar_dados():

    loading_animation("A carregar lista")
    separator()
    menu_panel("Presidentes")
    time.sleep(1)
    if len(presidentes) == 0:
            print("A lista está vazia, introduza valores na lista.")
            time.sleep(0.5)
            separator()

    nome_presidente = input("Introduza o nome do presidente que deseja alterar: ")

    presidente_encontrado = None
    for presidente in presidentes:
        if presidente["nome"] == nome_presidente:
            presidente_encontrado = presidente
            break
    
    if presidente_encontrado is not None:
        #Pergunta ao User qual o dado que pretende mudar
        #Exemplo: "nome" "ano_inicio" "ano_fim" "partido"
        dado_a_alterar= input("Introduza o dado que pretende alterar(Nome), (ano_inicio), (ano_fim), (partido): ")
    
        if dado_a_alterar in presidente_encontrado:
            novo_valor = input(f"Introduza o valor novo para {dado_a_alterar}: ")
                
            presidente_encontrado[dado_a_alterar] = novo_valor
            print("Dados alterados com sucesso!")

        else:
            print(f"O {dado_a_alterar} não existe para o presidente.")
    else:
        print(f"Presidente{nome_presidente} não encontrado")

    input("ENTER p/continuar...")
def gerar_presidente():
    num = random.randint(0, 6)  # Ajustado para 5, pois você tem 6 listas
    presidentes_lista = [presidentes_gerar_1, presidentes_gerar_2, presidentes_gerar_3, presidentes_gerar_4, presidentes_gerar_5, presidentes_gerar_6, presidentes_gerar_7]
    presidentes.extend(presidentes_lista[num])
    loading_animation("A gerar lista")
    print("Lista de presidentes gerada com sucesso!")
    

    while True:
        user_input = input("Pretende ver a lista de presidentes?(S/N)").lower()
        if user_input == "s":
            ver_lista_presidentes()
            input("ENTER p/continuar...")
            break

        if user_input == "n":
            return
        
        if user_input != "s" and user_input != "n":
            error_message()
            print("Dados errados!")
            time.sleep(0.5)
def media_anos_mandato():
    """
    calcular a média de todos os mandatos na lista
        animação de "A calcular"
            Concluida!
    """
    loading_animation("A calcular")
    separator()
    menu_panel("Presidentes")
    time.sleep(1)

    total_anos_mandato = 0

    for presidente in presidentes:
        ano_inicio = presidente['ano_inicio']
        ano_fim = presidente['ano_fim']
        anos_mandato = ano_fim - ano_inicio
        total_anos_mandato += anos_mandato
    
    if len(presidentes) > 0:
        media = total_anos_mandato / len(presidentes)
        media_formatada = round(media)
        print(f"A média de anos de mandato na lista é: {media_formatada}, arredondando as unidades.")
    else:
        print("A lista de presidentes está vazia, impossivel calcular a média.")

    input("Enter p/continuar")
    clear_console()
def guardar_em_ficheiro(nome_arquivo='presidentes.json'):
    loading_animation("A guardar")
    with open(nome_arquivo, 'w') as f:
        json.dump(presidentes, f)
    input(f"Dados guardados em {nome_arquivo}.\nENTER p/continuar...")
def fechar_programa():
    user_in = input("Tem a certeza que pretende sair?(S/N)").upper()
    if user_in == "S":
        loading_animation("A fechar")
        exit()
    elif user_in == "N":
        return
    else:
        print("Input inválido, por favor 'S' para sim e 'N' para não.")

while True:
    # Limpa a consola sempre que o user volta para o loop.
    clear_console()
    # Menu que permite ao utilizador realizar todas as ações abaixo descritas.

    separator()
    menu_panel("Menu")
    separator()
    console.print("[bright_blue][b]1 - [/bright_blue][/b]Introduzir dados.", justify= "left")
    console.print("[bright_blue][b]2 - [/bright_blue][/b]Ver lista atual.", justify= "left")
    console.print("[bright_blue][b]3 - [/bright_blue][/b]Comparar presidentes.",justify= "left")
    console.print("[bright_blue][b]4 - [/bright_blue][/b]Pesquisar por presidente.",justify= "left")
    console.print("[bright_blue][b]5 - [/bright_blue][/b]Ver por partido.",justify= "left")
    console.print("[bright_blue][b]6 - [/bright_blue][/b]Eliminar dados da lista.", justify= "left")
    console.print("[bright_blue][b]7 - [/bright_blue][/b]Alterar dados de um presidente.", justify= "left")
    console.print("[bright_blue][b]8 - [/bright_blue][/b]Gerar lista de presidentes.", justify= "left")
    console.print("[bright_blue][b]9 - [/bright_blue][/b]Calcular a média de anos por mandato.", justify= "left")
    console.print("[bright_blue][b]10 - [/bright_blue][/b]Guardar em ficheiro.", justify= "left")
    console.print("[bright_blue][b]11 - [/bright_blue][/b]Sair do programa.",justify= "left")
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
            guardar_em_ficheiro()
        case "11":
            fechar_programa()
        case _:
            print("Por favor, introduza uma opção dentro de 1 a 12.")