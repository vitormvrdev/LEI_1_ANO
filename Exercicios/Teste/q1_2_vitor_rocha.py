def converte_temp(temp, unidade):
    calc = 0
    if unidade == "F":
        calc = temp * 1.8 + 32
    elif unidade == "K":
        calc = temp + 273.15
    elif unidade == "R":
        calc = (temp + 273.15) * 1.8
    return calc
    
def main():
    temp = float(input("Temperatura em ºC........: "))
    unidade = input("Unidade p/converter (F,K,R).: ").upper()
    conversao = converte_temp(temp, unidade)
    print(conversao)
    pass

main()