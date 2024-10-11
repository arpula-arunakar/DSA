class SumOfNumbers:
    def sum_of_numbers(self, n):
        if n > 0:
            return self.sum_of_numbers(n - 1) + n
        return 0

    def main(self):
        print("------------------------------------")
        print("Enter 'N'")

        n = int(input())
        res = self.sum_of_numbers(n)

        print(f"Sum of {n} numbers is: {res}")
        return res
