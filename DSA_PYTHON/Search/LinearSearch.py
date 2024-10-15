class LinearSearch:

    def linear(self, array, target):
        for index, value in enumerate(array):
            if value == target:
                return index
        return -1

    def main(self):
        print("------------------------------------")
        array = [6, 2, 7, 4, 8, 10]

        print("Enter element to search: ")
        n = int(input())
        res = self.linear(array, n)
        if res == -1:
            print("Item not found")
        else:
            print(f"Item found at index {res}")
        return res

