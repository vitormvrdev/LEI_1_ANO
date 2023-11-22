i = 0
codigo = ""
while codigo != "isla":
    if i == 3:
        print("Access Denied")
        quit()
    codigo = input("Código: (isla): ")
    i += 1
print("Access Granted")