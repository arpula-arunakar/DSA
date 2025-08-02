
class ToeplitzMatrix:
    # A Toeplitz matrix(also called a diagonal-constant matrix) is a matrix in which each descending diagonal from left to right is constant.
    # This means that all elements along a diagonal have the same value.

    def read_matrix(self, n):
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        print("Enter elements for Toeplitz Matrix:")

        # First row
        for j in range(n):
            matrix[0][j] = int(input(f"Element [0][{j}]: "))

        # First column (excluding [0][0])
        for i in range(1, n):
            matrix[i][0] = int(input(f"Element [{i}][0]: "))

        # Fill rest using diagonal rule
        for i in range(1, n):
            for j in range(1, n):
                matrix[i][j] = matrix[i - 1][j - 1]

        return matrix

    def print_matrix(self, matrix):
        print("\nToeplitz Matrix Output:")
        for row in matrix:
            for val in row:
                print(val, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = self.read_matrix(n)
        self.print_matrix(matrix)
