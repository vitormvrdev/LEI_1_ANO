def ler_dados(lista_dados):

    while True:
        print("Regsito nº " + str(len(lista_dados) + 1))

        numero = int(input(" Numero (0 termina)..: "))

        if numero == 0:
            break

        nome = input(" Nome................: ")
        salario = float(input(" Salário.............: "))

        irs = salario * 20 / 100
        seg_social = salario * 11 / 100

        print(f" IRS.................: {irs}")
        print(f" Seg. Social.........: {seg_social}")

        # definir registo e coloca-lo na lista
        registo = [numero, nome, salario, irs, seg_social]
        lista_dados.append(registo)

        print(registo)
        print(lista_dados)
        print()


def ver_dados(lista_dados):

    print("Numero  Nome                            Salario     IRS         Seg Social")
    print("-------------------------------------------------------------------------")

    # percorrer toda a lista
    n = len(lista_dados)

    for i in range(n):
        print(lista_dados[i][0], " "*(6 - len(str(lista_dados[i][0]))),
              lista_dados[i][1], " "*(30 - len((lista_dados[i][1]))),
              lista_dados[i][2], " "*(10 - len(str(lista_dados[i][2]))),
              lista_dados[i][3], " "*(10 - len(str(lista_dados[i][3]))),
              lista_dados[i][4])

    # pausa
    input("ENTER p/ terminar...")


def salario_maximo(lista_dados):
    # exemplo da lisa: [[100, 'Nome 1', 1500, 300.0, 165.0], [200, 'Nome 2', 1000, 200.0, 110.0]]
    # assumnir que o maior é o 1º, para referencia
    sal_max = lista_dados[0][2]  # -> salário do indice 0, no exemplo 1500

    # percorrer todaa lista
    for i in range(len(lista_dados)):
        if lista_dados[i][2] > sal_max:
            sal_max = lista_dados[i][2]

    return sal_max


def guardar_ficheiro(lista_dados):

    ficheiro = open("dados_func.txt", "w")

    ficheiro.write("Numero, Nome, Salario, IRS, SegSocial\n")

    # percorrer toda a lista
    n = len(lista_dados)

    for i in range(n):  
        ficheiro.write(str(lista_dados[i][0]) + ", " + 
                        lista_dados[i][1] + ", " +
                        str(lista_dados[i][2]) + ", " + 
                        str(lista_dados[i][3]) + ", " + 
                        str(lista_dados[i][4]) + "\n")

    ficheiro.close()

    print()
    print("Ficheiro guardado!")
    # pausa
    input("ENTER p/ terminar...")

def abrir_ficheiro(lista_dados):

    ficheiro = open("dados_func.txt", "r")

    # percorrer todo o ficheiro
    contador = 1
    for linha in ficheiro.readlines():
        # exemplo de linha: 2000, jose, 2500.0, 500.0, 275.0
        # print(linha)

        if contador > 1: # ignorar a 1ª linha "Numero, Nome, Salario, IRS, SegSocial"
            # separar os campos através da virgula (,) e coloca-los nma lista
            lista_campos = linha.split(",")
            # print(lista_campos)

            numero = lista_campos[0].strip() # retira espaços brancos  
            nome =  lista_campos[1].strip() 
            salario =  float(lista_campos[2].strip()) 
            irs =  float(lista_campos[3].strip()) 
            seg_social =  float(lista_campos[4].strip()) 

            # definir registo e coloca-lo na lista
            registo = [numero, nome, salario, irs, seg_social]
            lista_dados.append(registo)

            #print(registo)        

        contador = contador + 1

    print(lista_dados)
    print()
    
    print("Ficheiro aberto!")

    # pausa
    input("ENTER p/ terminar...")    

def main():

    lista_dados = []

    while True:
        print("1. Introduzir dados")
        print("2. Ver dados")
        print("3. Salário Maior")
        print("4. Guardar dados em ficheiro")
        print("5. Recuperar dados do ficheiro")
        print("6. Sair")
        opcao = int(input("Escolha opção: "))

        if opcao == 1:
            ler_dados(lista_dados)
        elif opcao == 2:
            ver_dados(lista_dados)
        elif opcao == 3:
            max_sal = salario_maximo(lista_dados)
            print(f"Salário maior: {max_sal}")
            # pausa
            input("ENTER p/ terminar...")

        elif opcao == 4:
            guardar_ficheiro(lista_dados)
        elif opcao == 5:
            abrir_ficheiro(lista_dados)
        elif opcao == 6:
            break
        else:
            print("Opção errada!")

main()
