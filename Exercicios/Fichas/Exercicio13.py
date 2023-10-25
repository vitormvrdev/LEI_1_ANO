
peso = float(input("Introduza o peso: "))
planeta = input("Introduza o planeta que pretende calcular o peso \n 1- Mercúrio\n2- Vénus\n3- Urano\n4- Marte\n5- Júpiter\n6- Saturno")
pesoC = 0



match planeta:
    case "1":
        pesoC = (peso/10)*0.37
        print("", peso, "em Mercúrio é: ", round(pesoC, 2))
    case "2":
        pesoC = (peso / 10) * 0.88
        print("", peso, "em Vénus é: ", round(pesoC, 2))
    case "3":
        pesoC = (peso / 10) * 1.17
        print("", peso, "em Urano é: ", round(pesoC, 2))
    case "4":
        pesoC = (peso / 10) * 0.38
        print("", peso, "em Marte é: ", round(pesoC, 2))
    case "5":
        pesoC = (peso / 10) * 2.64
        print("", peso, "em Júpiter é: ", round(pesoC, 2))
    case "6":
        pesoC = (peso / 10) * 1.15
        print("", peso, "em Saturno é: ", round(pesoC, 2))
    case _:
        print("Não é possível ler esse número")

