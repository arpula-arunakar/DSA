
from Recursion.Factorial import Factorial
from Recursion.FibanocciSeries import FibanocciSeries
from Recursion.nCr import NCR
from Recursion.Power import Power
from Recursion.SumOfNumbers import SumOfNumbers
from Recursion.TaylorSeries import Exponential
from Recursion.TowerOfHanoi import TowerOfHanoi
from Search.LinearSearch import LinearSearch
from Search.BinarySearch import BinarySearch
from CodeExercises.FindMissingElement import FindMissingElement
from CodeExercises.FindMissingElements import FindMissingElements
from CodeExercises.FindDuplicatesInSortedArray import FindDuplicatesInSortedArray


def get_programs():
    return {
        1: ("Sum of 'N' Natural Numbers - Recursion", SumOfNumbers),
        2: ("Factorial - Recursion", Factorial),
        3: ("Power - Recursion", Power),
        4: ("Taylor Series - Recursion", Exponential),
        5: ("Fibonacci - Recursion", FibanocciSeries),
        6: ("nCr - Recursion", NCR),
        7: ("Tower Of Hanoi - Recursion", TowerOfHanoi),
        8: ("Linear Search", LinearSearch),
        9: ("Binary Search", BinarySearch),
        10: ("Find Missing Element(Single)", FindMissingElement),
        11: ("Find Missing Element(Multiple)", FindMissingElements),
        12: ("Find Duplicates(Sorted Array)", FindDuplicatesInSortedArray),
    }


def main():
    programs = get_programs()
    print("Select program to run")
    print("-------------------------------")
    for key, (description, _) in programs.items():
        print(f"{key}. {description}")
    print("-------------------------------")
    input_program = int(input("Select the program to run: "))

    program = programs.get(input_program)
    if program:
        program_instance = program[1]()
        program_instance.main()
    else:
        print("Not Found")


main()