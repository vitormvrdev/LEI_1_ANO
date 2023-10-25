
peso =  float(input("Introduza o seu peso em Kg: "))
altura =  float(input("Introduza a sua altura em metros: "))
imc = 0
imc = peso / ( altura * altura )
if imc < 20  :
    print( "está abaixo de peso" , end="")
else:
    if imc >= 20 and imc < 25  :
        print( "tem peso normal" , end="")
    else:
        if imc >= 25 and imc < 30  :
            print( "excesso de peso" , end="")
        else:
            if imc >= 30 and imc < 35  :
                print( "Obesidade" , end="")
            else:
                if imc >= 35  :
                    print( "Obesidade mórbida" , end="")
                else:
                    print( "Introduziu um valor impossível." , end="")


