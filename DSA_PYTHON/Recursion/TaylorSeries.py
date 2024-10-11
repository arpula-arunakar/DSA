class Exponential:
    def __init__(self):
        self.p = 1
        self.f = 1
        self.s = 1

    def e(self, x, n):
        if n == 0:
            return 1
        r = self.e(x, n - 1)
        self.p *= x
        self.f *= n
        return r + self.p / self.f

    # second version of doing "horner's rule"
    def ev2(self, x, n):
        if n == 0:
            return self.s
        self.s = 1 + x * self.s / n
        return self.ev2(x, n - 1)

    def main(self):
        print("------------------------------------")
        x = int(input("Enter 'x': "))
        n = int(input("Enter 'N': "))

        res = self.ev2(x, n)

        print(f"e^x is: {res}")
        return str(res)
