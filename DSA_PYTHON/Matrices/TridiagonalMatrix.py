
class TridiagonalMatrix:
    # A tridiagonal matrix is a special type of square matrix in which only the elements on the main diagonal, the diagonal just above it, and the diagonal just below it can be non-zero.
    # All other elements must be zero.
    def read_matrix(self, n):
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        print("Enter elements for Tridiagonal Matrix:")
        print("Note: Only fill positions where |i - j| <= 1")

        for i in range(n):
            for j in range(n):
                if abs(i - j) <= 1:
                    val = int(input(f"Element [{i}][{j}]: "))
                    matrix[i][j] = val
                else:
                    matrix[i][j] = 0
        return matrix

    def print_matrix(self, matrix):
        print("\nTridiagonal Matrix Output:")
        for row in matrix:
            for val in row:
                print(val, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = self.read_matrix(n)
        self.print_matrix(matrix)
