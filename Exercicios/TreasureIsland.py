print("Welcome to Treasure Island\n")
print("Your mission is to find the treasure\n")

user_input = input("left or right: \n").lower()
if user_input == "left":
    choice_2 = input("swim or stay\n").lower()
    if choice_2 == "stay":
        door_choice = input("which door? red, blue, or yellow\n").lower()
        if door_choice == "yellow":
            print("You win")
        else:
            print("You lose")
    else:
        print("You lost")
else:
    print("You lost")