def calcular_vencimento(horas_trabalhadas):
    valor_hora = 3.50
    numero_dias_semana = 5

    vencimento_bruto = valor_hora * horas_trabalhadas * numero_dias_semana

    desconto_seguranca_social = 0.15 * vencimento_bruto
    desconto_irs = 0.10 * vencimento_bruto

    vencimento_liquido = vencimento_bruto - desconto_seguranca_social - desconto_irs

    return vencimento_bruto, vencimento_liquido, desconto_seguranca_social, desconto_irs

def main():
    horas_trabalhadas = [float(input(f"Horas trabalhadas no dia {i + 1}: ")) for i in range(5)]

    vencimento_bruto, vencimento_liquido, desconto_seguranca_social, desconto_irs = calcular_vencimento(sum(horas_trabalhadas))

    print("\nResultados:")
    print(f"Vencimento bruto semanal: {vencimento_bruto} €")
    print(f"Desconto para Segurança Social: {desconto_seguranca_social} €")
    print(f"Desconto para IRS: {desconto_irs} €")
    print(f"Vencimento líquido semanal: {vencimento_liquido} €")

if __name__ == "__main__":
    main()
