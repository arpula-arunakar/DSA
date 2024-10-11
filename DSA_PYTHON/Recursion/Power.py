class Power:
    def pow(self, m, n):
        if n > 0:
            return self.pow(m, n - 1) * m
        return 1

    def main(self):
        print("------------------------------------")
        print("Enter 'M'")
        m = int(input())

        print("Enter 'N'")
        n = int(input())

        res = self.pow(m, n)
        print(f"{m} power {n} is: {res}")
        return res