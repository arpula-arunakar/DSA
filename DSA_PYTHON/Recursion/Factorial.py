class Factorial:
    def factorial(self,n):
        if(n>0):
            return self.factorial(n-1)*n
        return 1

    def main(self):
        print("------------------------------------")
        print("Enter 'N'")
    
        n = int(input())
        res=self.factorial(n)
    
        print(f"Factorial of {n} is: {res}")
        return res
