vendas_anual = []

def mes_maior_vendas(n, vendas_anual):
    mes_maior = 0
    for venda in vendas_anual:
        if mes_maior < venda:
            mes_maior = venda
    return mes_maior

def media_vendas(n, vendas_anual):
    soma = 0
    for venda in vendas_anual:
        soma += venda
        media = soma/n
    return media

def quant_meses_media(n, vendas_anual):
    contador = 0
    media = media_vendas(n, vendas_anual)
    for venda in vendas_anual:
        if venda > media:
            contador += 1
    return contador


while True:
    try:
        n = int(input("Introduz o caralho o número meu. "))
        if 1 <=  n <= 12:
            break
        else:
            print("Introduz outro número")
    except ValueError:
        print("Introduz um número inteiro de 1 a 12")

for i in range(n):
    valor_cada_mes = float(input("Introduza o valor monetário de cada um dos meses."))
    vendas_anual.append(valor_cada_mes)

mes_maior = mes_maior_vendas(n, vendas_anual)
print(mes_maior)

media = media_vendas(n, vendas_anual)
print(media)

quant_meses = quant_meses_media(n, vendas_anual)
print(quant_meses)