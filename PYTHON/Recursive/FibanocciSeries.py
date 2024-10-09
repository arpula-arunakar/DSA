class FibanocciSeries:
    def __init__(self):
        pass
    
    def Fibanocci(self,n):
        if n<=1: return n
        return self.Fibanocci(n-2)+self.Fibanocci(n-1)
    
def Main():
    print("------------------------------------")
    print("Enter 'N'")
    res=""
    n = int(input())
    fibObj=FibanocciSeries()
    for i in range(0,n):
       res= res +" "+ str(fibObj.Fibanocci(i))
    
    print(f"Fibanocci Series is: {res}")
    return res

Main()