import random
import json
import BNconfig

def carregar_leaderboard():
    try:
        with open("leaderboard.json", "r") as file:
            leaderboard = json.load(file)
    except FileNotFoundError:
        leaderboard = {}
    return leaderboard

def salvar_leaderboard(leaderboard):
    with open("leaderboard.json", "w") as file:
        json.dump(leaderboard, file)

def remover_jogador(leaderboard, nome):
    if nome in leaderboard: 
        del leaderboard[nome]
        salvar_leaderboard(leaderboard)
        print(f"O jogador {nome} foi removido da leaderboard.")
    else:
        print(f"O jogador {nome} não está na leaderboard.")

def criar_tabuleiro(tamanho):
    tabuleiro = []
    for _ in range(tamanho):
        tabuleiro.append(["O"] * tamanho)
    return tabuleiro

def exibir_tabuleiro(tabuleiro):
    for linha in tabuleiro:
        print(" ".join(linha))

def posicionar_navios(tabuleiro, num_navios):
    for _ in range(num_navios):
        linha = random.randint(0, len(tabuleiro) - 1)
        coluna = random.randint(0, len(tabuleiro[0]) - 1)
        while tabuleiro[linha][coluna] == "X":
            linha = random.randint(0, len(tabuleiro) - 1)
            coluna = random.randint(0, len(tabuleiro[0]) - 1)
        tabuleiro[linha][coluna] = "X"

def verificar_palpite(palpite, navios):
    linha, coluna = palpite
    return navios[linha][coluna] == "X"

def introduzir_nome():
    nome = input("Digite o seu nome: ")
    return nome

def exibir_leaderboard(leaderboard):
    print("\nLeaderboard:")
    for nome, vitorias in leaderboard.items():
        print(f"{nome}: {vitorias} vitórias")

def menu_inicial():
    print("\nMenu Inicial:")
    print("1. Jogar")
    print("2. Ver Leaderboard")
    print("3. Remover Jogador da Leaderboard")
    opcao = input("Escolha uma opção (1/2/3): ")
    return opcao

def jogar_batalha_naval(tamanho_tabuleiro, num_navios):
    print("Bem-vindo ao Jogo da Batalha Naval!")

    leaderboard = carregar_leaderboard()

    while True:
        opcao = menu_inicial()

        if opcao == "1":
            exibir_leaderboard(leaderboard)

            nome_jogador1 = introduzir_nome()
            if nome_jogador1 in leaderboard:
                print(f"Bem-vindo de volta, {nome_jogador1}!")
            else:
                leaderboard[nome_jogador1] = 0

            nome_jogador2 = introduzir_nome()
            while nome_jogador2 == nome_jogador1 or nome_jogador2 in leaderboard:
                print("Erro: Os nomes dos jogadores devem ser diferentes.")
                nome_jogador2 = introduzir_nome()

            leaderboard[nome_jogador2] = 0

            tabuleiro_jogador1 = criar_tabuleiro(tamanho_tabuleiro)
            tabuleiro_jogador2 = criar_tabuleiro(tamanho_tabuleiro)

            posicionar_navios(tabuleiro_jogador1, num_navios)
            posicionar_navios(tabuleiro_jogador2, num_navios)

            while True:
                print(f"\n{nome_jogador1}, é a sua vez!")
                exibir_tabuleiro(tabuleiro_jogador1)

                palpite_linha = int(input("Digite a linha do seu palpite: ")) - 1
                palpite_coluna = int(input("Digite a coluna do seu palpite: ")) - 1

                if (
                    0 <= palpite_linha < tamanho_tabuleiro
                    and 0 <= palpite_coluna < tamanho_tabuleiro
                ):
                    if verificar_palpite((palpite_linha, palpite_coluna), tabuleiro_jogador2):
                        print(f"Parabéns, {nome_jogador1}! Você acertou um navio de {nome_jogador2}!")
                        tabuleiro_jogador2[palpite_linha][palpite_coluna] = "X"
                    else:
                        print(f"Ops! {nome_jogador1}, você errou.")
                        tabuleiro_jogador2[palpite_linha][palpite_coluna] = "-"
                else:
                    print("Palpite fora do tabuleiro. Tente novamente.")

                if all("X" in linha for linha in tabuleiro_jogador2):
                    print(f"Parabéns, {nome_jogador1}! Você venceu! Todos os navios de {nome_jogador2} foram afundados!")
                    leaderboard[nome_jogador1] += 1
                    break

                print(f"\n{nome_jogador2}, é a sua vez!")
                exibir_tabuleiro(tabuleiro_jogador2)

                palpite_linha = int(input("Digite a linha do seu palpite: ")) - 1
                palpite_coluna = int(input("Digite a coluna do seu palpite: ")) - 1

                if (
                    0 <= palpite_linha < tamanho_tabuleiro
                    and 0 <= palpite_coluna < tamanho_tabuleiro
                ):
                    if verificar_palpite((palpite_linha, palpite_coluna), tabuleiro_jogador1):
                        print(f"Parabéns, {nome_jogador2}! Você acertou um navio de {nome_jogador1}!")
                        tabuleiro_jogador1[palpite_linha][palpite_coluna] = "X"
                    else:
                        print(f"Ops! {nome_jogador2}, você errou.")
                        tabuleiro_jogador1[palpite_linha][palpite_coluna] = "-"
                else:
                    print("Palpite fora do tabuleiro. Tente novamente.")

                if all("X" in linha for linha in tabuleiro_jogador1):
                    print(f"Parabéns, {nome_jogador2}! Você venceu! Todos os navios de {nome_jogador1} foram afundados!")
                    leaderboard[nome_jogador2] += 1
                    break

            salvar_leaderboard(leaderboard)

            print("\nNúmero de vitórias:")
            print(f"{nome_jogador1}: {leaderboard[nome_jogador1]} vitórias")
            print(f"{nome_jogador2}: {leaderboard[nome_jogador2]} vitórias")

        elif opcao == "2":
            exibir_leaderboard(leaderboard)

        elif opcao == "3":
            nome_para_remover = input("Digite o nome do jogador que deseja remover: ")
            remover_jogador(leaderboard, nome_para_remover)
            
        else:
            print("Opção inválida. Tente novamente.")
            continue

        jogar_novamente = input("Deseja jogar novamente? (s/n): ")
        if jogar_novamente.lower() != "s":
            break

# Configurações do jogo
#tamanho_tabuleiro = 5
#num_navios = 3

# Iniciar o jogo
jogar_batalha_naval(BNconfig.tamanho_tabuleiro, BNconfig.num_navios)
