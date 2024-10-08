def sum_of_numbers(n):
        if n > 0:
            return sum_of_numbers(n - 1) + n
        return 0

def main():
    print("------------------------------------")
    print("Enter 'N'")
    
    n = int(input())
    res = sum_of_numbers(n)
    
    print(f"Sum of {n} numbers is: {res}")
    return res

main()