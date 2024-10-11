class FibanocciSeries:
    def fibanocci(self, n):
        if n <= 1:
            return n
        return self.fibanocci(n - 2) + self.fibanocci(n - 1)

    def main(self):
        print("------------------------------------")
        print("Enter 'N'")
        res = ""
        n = int(input())
        fibObj = FibanocciSeries()
        for i in range(0, n):
            res = res + " " + str(fibObj.fibanocci(i))

        print(f"Fibanocci Series is: {res}")
        return res