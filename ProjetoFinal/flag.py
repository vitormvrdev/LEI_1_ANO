from rich.console import Console

def create_flag():
    console = Console()

    # Define the dimensions of the flag
    width = 60
    height = 10

    # Define the colors
    red = "[red]*[/red]"
    white = "[white] [/white]"
    blue = "[blue]*[/blue]"

    # Create the flag pattern
    flag = [
        [blue, white, blue, white, blue, white, blue, white, blue, white, blue, white, blue],
        [white, blue, white, blue, white, blue, white, blue, white, blue, white, blue, white],
        [blue, white, blue, white, blue, white, blue, white, blue, white, blue, white, blue],
        [white, blue, white, blue, white, blue, white, blue, white, blue, white, blue, white],
        [blue, white, blue, white, blue, white, blue, white, blue, white, blue, white, blue],
        [white, blue, white, blue, white, blue, white, blue, white, blue, white, blue, white],
        [blue, red, blue, red, blue, red, blue, red, blue, red, blue, red, blue],
        [white, blue, white, blue, white, blue, white, blue, white, blue, white, blue, white],
        [blue, white, blue, white, blue, white, blue, white, blue, white, blue, white, blue],
        [white, blue, white, blue, white, blue, white, blue, white, blue, white, blue, white],
    ]

    # Display the flag
    for row in flag:
        row_str = "".join(row)
        console.print(row_str.center(width))

if __name__ == "__main__":
    create_flag()
