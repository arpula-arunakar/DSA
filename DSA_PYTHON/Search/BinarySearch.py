
class BinarySearch:

    def binary(self, array, target):
        left, right = 0, len(array) - 1
        while left <= right:
            mid = (left + right) // 2
            if array[mid] == target:
                return mid
            elif target < array[mid]:
                right = mid - 1
            else:
                left = mid + 1
        return -1

    def main(self):
        print("------------------------------------")
        array = [2, 4, 6, 7, 8, 10, 17, 93]

        print("Enter element to search: ")
        n = int(input())
        res = self.binary(array, n)
        if res == -1:
            print("Item not found")
        else:
            print(f"Item found at index {res}")
        return res
