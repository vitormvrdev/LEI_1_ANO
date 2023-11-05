def sum_and_concat_true_love_letters(name1, name2):
    true_letters = "true"
    love_letters = "love"

    letter_counts = {
        't': 0,
        'r': 0,
        'u': 0,
        'e': 0,
        'l': 0,
        'o': 0,
        'v': 0,
    }

    name1 = name1.lower()
    name2 = name2.lower()

    for letter in name1:
        if letter in true_letters:
            letter_counts[letter] += 1
        if letter in love_letters:
            letter_counts[letter] += 1

    for letter in name2:
        if letter in true_letters:
            letter_counts[letter] += 1
        if letter in love_letters:
            letter_counts[letter] += 1

    true_sum = sum(letter_counts[letter] for letter in true_letters)
    love_sum = sum(letter_counts[letter] for letter in love_letters)

    result = str(true_sum) + str(love_sum)

    return int(result)

name1 = input("Introduce the first name: \n")
name2 = input("Introduce the second name: \n")
result = sum_and_concat_true_love_letters(name1, name2)

if result < 10:
    print(f"Your result is {result}, which means, you're not compatible.")
elif result > 10:
    print(f"Your result is {result}, better than nothing.")
else:
    print(f"Your result is {result}, you're highly compatible.")
 