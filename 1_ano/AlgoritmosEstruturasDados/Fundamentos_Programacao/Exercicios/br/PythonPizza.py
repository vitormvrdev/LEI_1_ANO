pizza_type = input("Enter what size Pizza you would like to order, S(Small), M(Medium), L(Large)")
bill_pizza = 0
bill_total = 0.00

match pizza_type:
    case "S":
        bill_pizza = 25
        bill_total += bill_pizza

        add_peperoni = input("Would you like peperoni on the pizza?").upper()
        wants_cheese = input("What about cheese?").upper()
        if add_peperoni == "Y":
            bill_total += 2
        if wants_cheese == "Y":
            bill_total += 1
        print(f"your total is {bill_total}")