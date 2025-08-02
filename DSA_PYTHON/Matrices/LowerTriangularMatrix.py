class LowerTriangularMatrix:
    # LowerTriangularMatrix: A lower triangular matrix is a square matrix in which all elements above the main diagonal are zero.
    def read_matrix(self, matrix):
        n = len(matrix)
        print("Enter matrix elements:")
        print("Note: Enter only the lower triangle (i >= j)")
        for i in range(n):
            for j in range(i + 1):
                matrix[i][j] = int(input(f"Element [{i},{j}]: "))

    def print_matrix(self, matrix):
        n = len(matrix)
        print("\nLower Triangular Matrix Output:")
        for i in range(n):
            for j in range(n):
                if i >= j:
                    print(matrix[i][j], end=" ")
                else:
                    print(0, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        self.read_matrix(matrix)
        self.print_matrix(matrix)
