class NCR:
    def nCr(self, n, r):
        if n == r or r == 0:
            return 1
        return self.nCr(n - 1, r - 1) + self.nCr(n - 1, r)

    def main(self):
        print("------------------------------------")

        print("Enter 'N'")
        n = int(input())

        print("Enter 'r'")
        r = int(input())

        res = self.nCr(n, r)
        print(f"Value of {n}C{r} is: {res}")
        return res