
class FindDuplicatesInSortedArray:
    def find_duplicates(self, array):
        i = 0
        while i < len(array) - 1:
            if array[i] == array[i + 1]:
                j = i + 1
                while array[j] == array[i]:
                    j += 1
                print(f"{array[i]} is appearing {j-i} times")
                i = j - 1
            else:
                i += 1

    def main(self):
        array = [3, 6, 8, 8, 10, 12, 15, 15, 15, 15, 20]
        self.find_duplicates(array)
        return ""