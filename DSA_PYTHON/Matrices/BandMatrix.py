
class BandMatrix:
    # A band matrix is a type of square matrix in which the non-zero elements are confined to a diagonal band — that is, the main diagonal and a fixed number of diagonals above and below it. All other elements are zero.
    def read_matrix(self, n, k):
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        print(f"Enter elements for band matrix with bandwidth {k}:")

        for i in range(n):
            for j in range(max(0, i - k), min(n, i + k + 1)):
                matrix[i][j] = int(input(f"Element [{i}][{j}]: "))
        return matrix

    def print_matrix(self, matrix):
        print("\nBand Matrix Output:")
        for row in matrix:
            for val in row:
                print(val, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        k = int(input("Enter the bandwidth (k): "))
        matrix = self.read_matrix(n, k)
        self.print_matrix(matrix)

