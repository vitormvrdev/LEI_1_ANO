def calcular_salario(horas_normais, horas_extras, num_dependentes):
    valor_hora_normal = 10
    valor_hora_extra = 15
    valor_dependente = 5
    horas_normais_semanais = 40

    # Calcular salário bruto
    valor_total_horas_normais = horas_normais * valor_hora_normal
    valor_total_horas_extras = horas_extras * valor_hora_extra
    valor_total_dependentes = num_dependentes * valor_dependente
    salario_bruto = valor_total_horas_normais + valor_total_horas_extras + valor_total_dependentes

    # Calcular descontos
    if salario_bruto <= 500:
        desconto_irs = 0
        desconto_ss = 0.05 * salario_bruto
        desconto_seguro_medico = 30
    elif salario_bruto <= 1300:
        desconto_irs = 0.08 * salario_bruto
        desconto_ss = 0.08 * salario_bruto
        desconto_seguro_medico = 80
    elif salario_bruto <= 2700:
        desconto_irs = 0.15 * salario_bruto
        desconto_ss = 0.10 * salario_bruto
        desconto_seguro_medico = 150
    else:
        desconto_irs = 0.25 * salario_bruto
        desconto_ss = 0.12 * salario_bruto
        desconto_seguro_medico = 320

    total_descontos = desconto_irs + desconto_ss + desconto_seguro_medico

    # Calcular salário líquido
    salario_liquido = salario_bruto - total_descontos

    return salario_bruto, total_descontos, salario_liquido

def main():
    num_funcionarios = 120
    total_gasto_salarios = 0

    for i in range(num_funcionarios):
        print(f"\nFuncionário {i + 1}:")
        horas_normais = float(input("Horas normais trabalhadas: "))
        horas_extras = float(input("Horas extras trabalhadas: "))
        num_dependentes = int(input("Número de dependentes: "))

        salario_bruto, total_descontos, salario_liquido = calcular_salario(horas_normais, horas_extras, num_dependentes)

        print("\nRecibo de Pagamento:")
        print(f"Salário Bruto: {salario_bruto} €")
        print(f"Total de Descontos: {total_descontos} €")
        print(f"Salário Líquido: {salario_liquido} €")

        total_gasto_salarios += salario_liquido

    print(f"\nTotal Gasto em Salários: {total_gasto_salarios} €")

if __name__ == "__main__":
    main()
