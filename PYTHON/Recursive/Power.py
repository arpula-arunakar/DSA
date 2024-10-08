def pow(m,n):
    if(n>0):
        return pow(m,n-1)*m
    return 1
def main():
    print("------------------------------------")
    print("Enter 'M'")
    m = int(input())
    
    print("Enter 'N'")
    n = int(input())
    
    res= pow(m,n)
    print(f"{m} power {n} is: {res}")
    return res
    
main()