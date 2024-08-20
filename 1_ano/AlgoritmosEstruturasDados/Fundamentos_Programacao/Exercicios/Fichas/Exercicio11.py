nomeRegiao = input(str("Introduza para onde pretende ir de Férias, escolha entre, Região Norte, Região Sul, Região Centro: "))

sentidoViagem = input(str("Indique se é viagem de ida e volta ou só de ida: "))


if nomeRegiao == "Norte" and sentidoViagem == "i":
    print("O valor da sua viagem será 25€.")
elif nomeRegiao == "Norte" and sentidoViagem == "v":
    print("O valor da sua viagem será 45€.")
if nomeRegiao == "Centro" and sentidoViagem == "i":
    print("O valor da sua viagem será 35€.")
elif nomeRegiao == "Centro" and sentidoViagem == "v":
    print("O valor da sua viagem será 65€.")
if nomeRegiao == "Sul" and sentidoViagem == "i":
    print("O valor da sua viagem será 45€.")
elif nomeRegiao == "Sul" and sentidoViagem == "v":
    print("O valor da sua viagem será 85€.")