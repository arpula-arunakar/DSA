
 
from Recursion.Factorial import Factorial
from Recursion.FibanocciSeries import FibanocciSeries
from Recursion.nCr import NCR
from Recursion.Power import Power
from Recursion.SumOfNumbers import SumOfNumbers
from Recursion.TaylorSeries import Exponential
from Recursion.TowerOfHanoi import TOH

def get_programs():
    return {
        1: ("Sum of 'N' Natural Numbers - Recursion", SumOfNumbers),
        2: ("Factorial - Recursion", Factorial),
        3: ("Power - Recursion", Power),
        4: ("Taylor Series - Recursion", Exponential),
        5: ("Fibonacci - Recursion", FibanocciSeries),
        6: ("nCr - Recursion", NCR),
        7: ("Tower Of Hanoi - Recursion", TOH),

    }

def main():
    programs = get_programs()
    print("Hello, World!")
    print("Select program to run")
    print("-------------------------------")
    for key, (description, _) in programs.items():
        print(f"{key}. {description}")
    print("-------------------------------")
    input_program = int(input("Enter the number of the program: "))
    
    program = programs.get(input_program)
    if program:
        program_instance = program[1]()
        program_instance.main()
    else:
        print("Not Found")

main()