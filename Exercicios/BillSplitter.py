
print("Welcome to the tip calculator.\n")
totalBill = float(input("What was the total bill?\n"))
pplBill = float(input("How many people to split the bill?\n"))
tip = int(input("What percentage tip would you like to give? none, 10, 12 or 15\n"))
tipOfBill = 0.0


if tip == 0:
    totalBill = totalBill / pplBill
    print("Each person has to pay: " + str(round(totalBill, 2)) + "€")
elif tip == 10:
    tipOfBill = totalBill * 0.1
    totalBill = totalBill + tipOfBill
    totalBill = totalBill / pplBill
    print("Each person has to pay: " + str(round(totalBill, 2)) + "€")
elif tip == 12:
    tipOfBill = totalBill * 0.12
    totalBill = totalBill + tipOfBill
    totalBill = totalBill / pplBill
    print("Each person has to pay: " + str(round(totalBill, 2)) + "€")
elif tip == 15:
    tipOfBill = totalBill * 0.15
    totalBill = totalBill + tipOfBill
    totalBill = totalBill / pplBill
    print("Each person has to pay: " + str(round(totalBill, 2)) + "€")
else:
    print("The % of tip you gave is not within the scope!")
