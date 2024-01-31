"""
Construa uma função (calcula_irs) (Python) que receba como parâmetro um valor em euros e calcule o
valor do IRS de acordo com as seguintes condições
-Se valor euros menor que 1000 então IRS é 10%
-Se valor euros maior de 1000 e inferior a 1500 então IRS é 20%
-Se valor euros maior de 1500 então IRS é 30%
Exemplo de chamada da função:
valor_euros = float(input(“Salário: “)
valor_IRS = calcula_irs(valor_euros) ou.. valor_IRS = calcula_irs(1500)
print(f“Valor IRS: {valor_IRS}”)
Apresente também o prog
"""
def calcula_irs(salario_predesconto):
    if salario_predesconto < 1000:
        salario_final = salario_predesconto * 0.1
    elif salario_predesconto < 1500:
        salario_final = salario_predesconto * 0.2
    elif salario_predesconto > 1500:
        salario_final  = salario_predesconto * 0.3
    return(salario_final)

salario_predesconto = float(input("Salário: "))
salario_final = calcula_irs(salario_predesconto)
print(f"IRS: {salario_final}")