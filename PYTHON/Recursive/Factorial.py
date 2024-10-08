def factorial(n):
    if(n>0):
        return factorial(n-1)*n
    return 1

def main():
    print("------------------------------------")
    print("Enter 'N'")
    
    n = int(input())
    res=factorial(n)
    
    print(f"Factorial of {n} is: {res}")
    return res
    
main()
    