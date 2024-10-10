def nCr(n,r):
    if n==r or r==0: return 1
    return nCr(n-1,r-1)+nCr(n-1,r)

def main():
    print("------------------------------------")
    
    print("Enter 'N'")
    n = int(input())
    
    print("Enter 'r'")
    r = int(input())
    
    res= nCr(n,r)
    print(f"Value of {n}C{r} is: {res}")
    return res
    
    
main()    