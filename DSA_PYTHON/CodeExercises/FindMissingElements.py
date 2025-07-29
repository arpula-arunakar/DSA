class FindMissingElements:
    def missing_numbers(self, array):
        diff = array[0] - 0

        for i in range(len(array)):
            while array[i] - i > diff:
                print(i + diff)
                diff += 1

    def main(self):
        array = [6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19]
        self.missing_numbers(array)
        return ""
