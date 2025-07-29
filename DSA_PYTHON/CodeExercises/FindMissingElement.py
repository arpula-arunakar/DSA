
class FindMissingElement:

    def missing_in_first_n_numbers(self,arr):
        total_sum=sum(arr)
        n=arr[-1]
        expected_sum=n*(n+1)//2
        return expected_sum-total_sum

    def main(self):
        array = [1, 2, 3, 4, 5, 6, 8, 9, 10]
        res = self.missing_in_first_n_numbers(array)
        print(f"Missing element is: {res}")
        return str(res)

