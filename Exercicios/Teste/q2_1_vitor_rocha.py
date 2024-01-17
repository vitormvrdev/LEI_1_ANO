def escreve_anos_bissextos(ano_inicial, ano_final):
    while ano_final > ano_inicial:
        if ((ano_inicial % 4 == 0 and ano_inicial % 100 != 0) or (ano_inicial % 100 == 0 and ano_inicial % 400 == 0)):
            print(ano_inicial)
            ano_inicial += 1

def main():    
    ano_inicial = int(input("Ano Inicial.: "))
    ano_final = int(input("Ano Final.: "))
    escreve_anos_bissextos(ano_inicial, ano_final)

main()
